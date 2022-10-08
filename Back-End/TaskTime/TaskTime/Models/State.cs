namespace TaskTime.Models
{
    public class State
    {
        public int Id { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public int EmployeeId { get; set; }
        public string EmployeeState { get; set; }
    }
}
