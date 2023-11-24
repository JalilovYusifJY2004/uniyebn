using Microsoft.EntityFrameworkCore;
using WebApplication2.Model;

namespace WebApplication2.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) 
        { 

        }
        public DbSet<Department> Departments { get; set; }
    }
}
