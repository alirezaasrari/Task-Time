using TaskTime.services;

namespace TaskTime.Models
{
    public class SecondPage
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;
        public int EmployeeId { get; set; }
        public string Emotion { get; set; }
        public string Description { get; set; }
    }
}
