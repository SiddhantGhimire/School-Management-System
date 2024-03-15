using Microsoft.EntityFrameworkCore;

namespace EmployeeMagementSystem.Models
{
    public class EmployeeeManagementSystemDbContext : DbContext
    {
        public EmployeeeManagementSystemDbContext(DbContextOptions<EmployeeeManagementSystemDbContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
   


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            foreach (var property in modelBuilder.Model.GetEntityTypes()
                .SelectMany(t => t.GetProperties())
                .Where(p => p.ClrType == typeof(string)))
            {
                property.SetColumnType("text");  // or "varchar"
            }

            // Other model configurations...
        }
    }



}

