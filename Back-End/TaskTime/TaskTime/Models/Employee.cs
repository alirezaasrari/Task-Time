using TaskTime.Data;
using TaskTime.services;

namespace TaskTime.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime date { get; set; } = DateTime.Now;
    }
}
