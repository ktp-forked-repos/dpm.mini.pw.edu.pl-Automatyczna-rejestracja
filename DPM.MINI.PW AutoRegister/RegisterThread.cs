using DPM.MINI.PW_AutoRegister.Structs;
using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace DPM.MINI.PW_AutoRegister
{
    public class RegisterThread
    {
        private readonly MainForm _form;

        private Thread _thr;

        public RegisterThread(MainForm form)
        {
            _form = form;
        }

        public void Start()
        {
            _thr = new Thread(Run);
            _thr.IsBackground = true;
            _thr.Start();
        }

        public void Stop()
        {
            _thr.Abort();
            _thr = null;
        }

        public void UpdateForm()
        {
            _form.Invoke((MethodInvoker) delegate { _form.UpdateTasksUI(); });
        }

        private void Run()
        {
            while (true)
            {
                var unix = new DateTime(1970, 1, 1);
                var now = DateTime.Now;
                var totalSeconds = now.Subtract(unix).TotalSeconds;

                for (var i = 0; i < _form.Tasks.Count; i++)
                {
                    if (_form.Tasks[i].state == PwState.Idle && _form.Tasks[i].timestamp <= totalSeconds)
                    {
                        _form.Tasks[i].state = PwState.Processing;
                        UpdateForm();
                        
                        var wc = new WebClientEx();
                        wc.Headers.Add("user-agent", MainForm.UserAgent);

                        var url = new Uri($"https://dpm.mini.pw.edu.pl/node/{_form.Tasks[i].id}/register");

                        // Add session cookie
                        wc.CookieContainer.Add(url, _form.SessionCookie);
                        
                        // Execute
                        try
                        {
                            // Get form_token
                            var get = wc.DownloadString(url);
                            var match = Regex.Match(get, @"name=\""form_token\"" value=\""(.*?)\""");

                            if (!match.Success)
                            {
                                throw new Exception("form_token not found");
                            }

                            var post = new NameValueCollection
                            {
                                {"count", _form.Tasks[i].count}, 
                                {"form_token", match.Groups[1].Value},
                                {"form_id", "registration_form"},
                            };

                            var result = wc.UploadValues(url, post);
                            var result_str = Encoding.UTF8.GetString(result);

                            if (result_str.Contains("Rejestracja została zapisana"))
                            {
                                // Success :)
                                _form.Tasks[i].state = PwState.Success;
                                UpdateForm();
                                continue;
                            }
                        }
                        catch (WebException ex)
                        {
                            // Timeout? Network error? Try again!
                        }
                        catch (Exception ex)
                        {
                            Debugger.Break();
                        }

                        _form.Tasks[i].state = PwState.Idle;
                        UpdateForm();
                    }
                }

                // Sleep for 500ms
                Thread.Sleep(500);
            }
        }
    }
}
