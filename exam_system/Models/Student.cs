using System.ComponentModel.DataAnnotations.Schema;

namespace exam_system.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string email { get; set; }
        public string Password { get; set; }
        public int grade { get; set; }
        public List<Ins_Stud> ins_studs { get;}
        
       
    }
}
