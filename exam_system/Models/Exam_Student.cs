using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace exam_system.Models
{
    [PrimaryKey("Ex_Id", "Stu_Id")]
    public class Exam_Student
    {
        [ForeignKey("exams")]
        public int Ex_Id { get; set; }
        [ForeignKey("stds")]
        public int? Stu_Id { get; set; }
        public Exam exams { get; set; }
        public Student? stds { get; set; }
    }
}
