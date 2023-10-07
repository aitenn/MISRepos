using Microsoft.EntityFrameworkCore;
using MISApp.Models;

namespace MISApp.MyDBContext
{
    public class MyDbContext : DbContext
    {
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connectionString: "Server=localhost;Database=MIS;User Id=ai-10;Password=ai-10;TrustServerCertificate=True");
        }

    }
}
