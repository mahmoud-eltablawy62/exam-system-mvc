using exam_system.viewModels;
using Microsoft.EntityFrameworkCore;
using System;

namespace exam_system.Models
{
    public class ExamContext : DbContext
    {
        public DbSet<Student> students { get; set; }    
        public DbSet<Exam> exams { get; set; }
        public DbSet<Exam_Student> exam_Students { get; set; }
        public DbSet<Instractor> instractors { get; set; }  
        public DbSet<Questions> questions { get; set; }
        
         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=exam_System;Trusted_Connection=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Instractor>()
                .HasIndex(p => p.Email)
                .IsUnique();

            modelBuilder.Entity<Student>()
                .HasIndex(p => p.email)
                .IsUnique();

        }

    }
}

