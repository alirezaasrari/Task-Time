using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using TaskTime.Models;

namespace TaskTime.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
    }
}
