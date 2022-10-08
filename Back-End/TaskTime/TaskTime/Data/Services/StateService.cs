using TaskTime.Models;
using TaskTime.Models.ViewModels;

namespace TaskTime.Data.Services
{
    public class StateService
    {
        public DataContext _context;
        public StateService(DataContext context)
        {
            _context = context;
        }
        public void AddState(StateVM state)
        {
                var _state = new State()
                {
                   EmployeeId = state.EmployeeId,
                   EmployeeState = state.EmployeeState,
                };
                _context.States.Add(_state);
                _context.SaveChanges();
        }

        public List<State> GetAllStates() => _context.States.ToList();
    }
}
