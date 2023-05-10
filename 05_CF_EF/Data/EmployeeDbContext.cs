using Microsoft.EntityFrameworkCore;
using K08_CF_EF.Models;

namespace K08_CF_EF.Data
{
    public class EmployeeDbContext : DbContext
    {
        // constructor
        public EmployeeDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Employee> Employees { get; set; } // Employees -> DB tarafındaki tablo 
    }
}
