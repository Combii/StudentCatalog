using Microsoft.EntityFrameworkCore;
using StudentsCatalog.Models.Entities;

namespace StudentsCatalog.Models
{
    class StudentDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

//DbContext<StudentDbContext> Students 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./StudentCatalog.db");
        }
    }
}