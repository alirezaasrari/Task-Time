namespace TaskTime.Models
{
    public class SecondPage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;
        public string Emotion { get; set; }
        public string Description { get; set; }
    }
}
