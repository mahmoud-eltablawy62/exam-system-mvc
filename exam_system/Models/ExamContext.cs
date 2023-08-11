using Microsoft.EntityFrameworkCore;

namespace exam_system.Models
{
    public class ExamContext : DbContext
    {
        public DbSet<Student> students { get; set; }    
        public DbSet<Exam> exams { get; set; }
        public DbSet<Exam_Student> exam_Students { get; set; }
        public DbSet<Instractor> instractors { get; set; }  
        public DbSet<Questions> questions { get; set; }
        public DbSet<Ins_Stud> ins_studs { get; set; }  
         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=exam_System;Trusted_Connection=True;TrustServerCertificate=True");
        }
     }
}
