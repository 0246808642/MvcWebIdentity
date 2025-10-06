using Microsoft.EntityFrameworkCore;
using MvcWebIdentity.Entities;

namespace MvcWebIdentity.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext>options): DbContext(options)
    {
        public DbSet<Student> Students { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>().HasData(new Student
            {
                Id = 1,
                Name = "Caique",
                Email = "Caique@gmail.com",
                Idade = 21,
                Course = "Programador C#"
            });
        }
    }
}
