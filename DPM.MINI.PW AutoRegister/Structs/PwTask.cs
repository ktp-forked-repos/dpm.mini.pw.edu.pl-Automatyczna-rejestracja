namespace DPM.MINI.PW_AutoRegister.Structs
{
    public class PwTask
    {
        public string id;
        public string count;
        public string hour;
        public string minute;
        
        // DateTime.TotalSeconds = double
        public double timestamp;

        public PwState state;
    }
}
