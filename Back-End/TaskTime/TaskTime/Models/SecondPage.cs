using TaskTime.services;

namespace TaskTime.Models
{
    public class SecondPage
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;
        public string Emotion { get; set; }
        public string Description { get; set; }
        public int Stars { get; set; }
    }
}
