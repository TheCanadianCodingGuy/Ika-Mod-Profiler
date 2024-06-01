namespace playtarky.Models
{
    public class UserProfile
    {
        public Info info { get; set; }
    }

    public class Info
    {
        public string id { get; set; }
        public string username { get; set; }
    }
}