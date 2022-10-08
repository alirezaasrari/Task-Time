using TaskTime.Data;
using TaskTime.Models;

namespace TaskTime.services
{
    public class EmployeeService
    {
        private DataContext _context;
        public EmployeeService(DataContext context)
        {
            _context = context;
        }

        public Employee UpdateEmployeeById(int employeeId, Employee employee)
        {
            var _employee = _context.Employees.FirstOrDefault(n => n.Id == employeeId);
            if(_employee != null)
            {
                _employee.Name = employee.Name;

                _context.SaveChanges();
            }
            return _employee;
        }
    }
}
