namespace playtarky.Models
{
    public class JsonFile<T>
    {
        public string Path {  get; set; }
        public T File { get; set; }
    }
}
