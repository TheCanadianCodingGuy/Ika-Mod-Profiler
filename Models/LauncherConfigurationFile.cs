namespace playtarky.Models
{
    public class LauncherConfigurationFile
    {
        public bool FirstRun { get; set; }
        public string DefaultLocale { get; set; }
        public int LauncherStartGameAction { get { return 0; }}
        public bool UseAutoLogin { get; set; }
        public string GamePath { get; set; }
        public object[] ExcludeFromCleanup { get { return []; }}
        public Server Server { get; set; }
    }

    public class Server
    {
        public Autologincreds AutoLoginCreds { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
    }

    public class Autologincreds
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
