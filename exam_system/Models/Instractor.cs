using System.ComponentModel.DataAnnotations.Schema;

namespace exam_system.Models
{
    public class Instractor
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
         
        public List <Questions> ? Ques { get; set; } 
        public List <Ins_Stud> ? ins_studs { get ; set; }   
    }
}
