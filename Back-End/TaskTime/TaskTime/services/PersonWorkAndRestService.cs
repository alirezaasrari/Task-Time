using TaskTime.Data;
using TaskTime.Models;

namespace TaskTime.services
{
    public class PersonWorkAndRestService
    {
        private readonly DataContext _context;
        public PersonWorkAndRestService(DataContext context)
        {
            _context = context;
        }

        public void AddRest(PersonWorkAndRest personWorkAndRest)
        {
            int _workTime = 0;
            DateTime _workDay = DateTime.Now;

            if (personWorkAndRest.State == 0)
            {
              // _workTime = personWorkAndRest;
              // _workDay = personWorkAndRest;
            }
        }
    }
}
