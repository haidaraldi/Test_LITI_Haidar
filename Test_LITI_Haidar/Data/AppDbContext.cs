using Microsoft.EntityFrameworkCore;
using Test_LITI_Haidar.Models;

namespace Test_LITI_Haidar.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
    }
}
