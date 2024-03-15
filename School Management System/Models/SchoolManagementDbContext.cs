using Microsoft.EntityFrameworkCore;

namespace School_Management_System.Models
{
    public class SchoolManagementDbContext : DbContext 
    {

        public SchoolManagementDbContext(DbContextOptions<SchoolManagementDbContext> options) : base(options) { 
        
        }

        public DbSet <Student> Students { get; set; }
        public DbSet <Teacher> Teachers { get; set; }

        public DbSet<Classes> Classes { get; set; } 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            foreach (var property in modelBuilder.Model.GetEntityTypes()
                .SelectMany(t => t.GetProperties())
                .Where(p => p.ClrType == typeof(string)))
            {
                property.SetColumnType("text");
            }

        }
    }
}
