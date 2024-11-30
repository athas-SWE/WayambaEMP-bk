using Microsoft.EntityFrameworkCore;
using Weaapp.Models;

namespace Weaapp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options) 
        {
            
        }

        public DbSet<Employee> Employees { get; set; }

    }
}
