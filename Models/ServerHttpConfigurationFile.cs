namespace playtarky.Models
{
    public class ServerHttpConfigurationFile
    {
        public string ip { get; set; }
        public int port { get; set; }
        public string backendIp { get; set; }
        public int backendPort { get; set; }
        public int webSocketPingDelayMs { get; set; }
        public bool logRequests { get; set; }
        private List<string> serverImagePathOverride { get { return []; } }
    }


}
