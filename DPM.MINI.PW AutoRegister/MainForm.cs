using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using DPM.MINI.PW_AutoRegister.Structs;

namespace DPM.MINI.PW_AutoRegister
{
    public partial class MainForm : Form
    {
        public const string UserAgent = "DPM.MINI.PW_AutoRegister/1.0 (+Kamil Monicz)";
        private const int PwTasksLimit = 6;

        public readonly List<PwTask> Tasks = new List<PwTask>();

        public string SessionName;
        public Cookie SessionCookie;

        public MainForm()
        {
            InitializeComponent();

            var registerThread = new RegisterThread(this);
            registerThread.Start();
        }

        public void UpdateTasksUI()
        {
            tasks_panel.Controls.Clear();

            for (var i = 0; i < Tasks.Count; i++)
            {
                var panel = new Panel();

                panel.Width = tasks_panel.Width;
                panel.Height = 36;

                if (i % 2 == 0)
                {
                    panel.BackColor = SystemColors.ControlLightLight;
                }
                else
                {
                    panel.BackColor = SystemColors.ControlLight;
                }

                var id_label = new Label();

                id_label.AutoSize = true;
                id_label.Left = 9;
                id_label.Top = 11;

                id_label.Text = $"#{Tasks[i].id} ({Tasks[i].hour}:{Tasks[i].minute})";

                var status_desc_label = new Label();
                
                status_desc_label.AutoSize = true;
                status_desc_label.Left = 97;
                status_desc_label.Top = 11;

                status_desc_label.Text = "Status:";

                var status_label = new Label();
                
                status_label.AutoSize = true;
                status_label.Left = 143;
                status_label.Top = 11;

                status_label.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold);

                switch (Tasks[i].state)
                {
                    case PwState.Idle:
                    {
                        status_label.Text = "oczekuje...";
                        status_label.ForeColor = SystemColors.ControlText;
                        break;
                    }
                    case PwState.Processing:
                    {
                        status_label.Text = "działam...";
                        status_label.ForeColor = Color.DarkOrange;
                        break;
                    }
                    case PwState.Success:
                    {
                        status_label.Text = "sukces";
                        status_label.ForeColor = Color.Green;
                        break;
                    }
                    case PwState.Fail:
                    {
                        status_label.Text = "niepowodzenie";
                        status_label.ForeColor = Color.Red;
                        break;
                    }
                }

                var del_button = new Button();

                del_button.Text = "Usuń";
                del_button.Left = 581;
                del_button.Top = 6;
                del_button.Width = 48;
                del_button.Height = 23;
                del_button.Tag = i;

                del_button.Click += (sender, args) =>
                {
                    Tasks.RemoveAt((int) del_button.Tag);
                    UpdateTasksUI();
                };
                
                panel.Controls.Add(id_label);
                panel.Controls.Add(status_desc_label);
                panel.Controls.Add(status_label);
                panel.Controls.Add(del_button);
                tasks_panel.Controls.Add(panel);
            }
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            if (SessionName != null)
            {
                // Already logged in
                return;
            }

            var wc = new WebClientEx();
            wc.Headers.Add("user-agent", UserAgent);

            var url = new Uri("https://dpm.mini.pw.edu.pl/?destination=");
            var post = new NameValueCollection
            {
                {"name", username_box.Text}, 
                {"pass", password_box.Text}, 
                {"form_id", "user_login_block"}
            };

            // Execute
            wc.UploadValuesTaskAsync(url, post)
                .ContinueWith(task =>
                {
                    var cookies = wc.CookieContainer.GetCookies(url).Cast<Cookie>();

                    // Gather cookie data
                    foreach (var cookie in cookies)
                    {
                        if (cookie.Name.StartsWith("SESS", StringComparison.Ordinal))
                        {
                            SessionName = cookie.Name;
                            SessionCookie = cookie;
                        }
                    }

                    if (SessionName != null)
                    {
                        // Success
                        Invoke((MethodInvoker) delegate
                        {
                            login_panel.Visible = false;
                            info_panel.Visible = true;

                            username_ro_box.Text = username_box.Text;
                            cookie_ro_box.Text = SessionName;
                        });
                    }
                    else
                    {
                        // Fail
                        Invoke((MethodInvoker) delegate
                        {
                            var res = MessageBox.Show("Logowanie nie powiodło się\r\nSprawdź czy podany login i hasło są poprawne", "Błąd", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                            if (res == DialogResult.Retry)
                            {
                                login_button.PerformClick();
                            }
                        });
                    }

                    wc.Dispose();
                });
        }

        private void node_add_button_Click(object sender, EventArgs e)
        {
            if (SessionName == null)
            {
                // Login required
                MessageBox.Show("Proszę najpierw się zalogować", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (Tasks.Count >= PwTasksLimit)
            {
                // Out of limit
                MessageBox.Show($"Nie możesz dodać więcej zadań (limit: {PwTasksLimit})", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            if (string.IsNullOrWhiteSpace(node_id_box.Text) || 
                string.IsNullOrWhiteSpace(node_count_box.Text) || 
                string.IsNullOrWhiteSpace(node_time_hour_box.Text) || 
                string.IsNullOrWhiteSpace(node_time_min_box.Text))
            {
                // Out of limit
                MessageBox.Show("Proszę wypełnić wszystkie pola", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var hour = node_time_hour_box.Text.Trim();
            var minute = node_time_min_box.Text.Trim();

            if (!int.TryParse(hour, out var hour_i))
            {
                // Parse error
                MessageBox.Show("Niepoprawna wartość godziny", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (hour_i < 0 || hour_i > 23)
            {
                // Out of range
                MessageBox.Show("Taka godzina nie istnieje", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(minute, out var minute_i))
            {
                // Parse error
                MessageBox.Show("Niepoprawna wartość minuty", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (minute_i < 0 || minute_i > 59)
            {
                // Out of range
                MessageBox.Show("Taka minuta nie istnieje", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var unix = new DateTime(1970, 1, 1);
            var now = DateTime.Now;
            var d = new DateTime(now.Year, now.Month, now.Day, hour_i, minute_i, 0);

            if (d.Subtract(unix).TotalSeconds <= now.Subtract(unix).TotalSeconds)
            {
                // Add 1 day if hour is earlier than now
                d = d.AddDays(1);
            }

            Tasks.Add(new PwTask
            {
                id = node_id_box.Text.Trim(),
                count = node_count_box.Text.Trim(),
                hour = hour,
                minute = minute,
                timestamp = d.Subtract(unix).TotalSeconds,
                state = PwState.Idle,
            });

            node_id_box.Text = null;
            node_count_box.Text = "1";
            node_time_hour_box.Text = "10";
            node_time_min_box.Text = "00";

            UpdateTasksUI();
        }
    }
}
