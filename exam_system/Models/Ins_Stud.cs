using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace exam_system.Models
{
    [PrimaryKey("Stud_Id", "Ins_Id")]
    public class Ins_Stud
    {
        [ForeignKey("Studs")]
        public int Stud_Id { get; set; }
        [ForeignKey("Incs")]
        public int Ins_Id { get; set; }
        public Student Studs { get; set; }
        public Instractor Incs { get; set; }    



    }
}
