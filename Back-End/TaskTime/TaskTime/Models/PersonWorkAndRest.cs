using ExpressTimezone;
using TaskTime.services;

namespace TaskTime.Models
{
    public class PersonWorkAndRest
    {
        public int Id { get; set; }
        public int  State { get; set; }
        public int UserId { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;
    }
}
