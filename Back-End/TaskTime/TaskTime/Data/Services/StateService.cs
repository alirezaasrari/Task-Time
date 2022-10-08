﻿using TaskTime.Models;
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
        public State GetEmployeeStateById(int employeeId)
        {
            var employeestate = _context.States.FirstOrDefault(x => x.Id == employeeId);
            return employeestate;
        }

        public State UpdateState(int EmployeeId, StateVM state)
        {
            var _statetobeupdate = _context.States.FirstOrDefault(n => n.Id == EmployeeId);
            if(_statetobeupdate != null)
            {
                _statetobeupdate.EmployeeState = state.EmployeeState;
                _statetobeupdate.EmployeeId = state.EmployeeId;
                _context.SaveChanges();
            };
            return _statetobeupdate;
        }

    }
}
