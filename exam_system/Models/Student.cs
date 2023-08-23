using Newtonsoft.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace exam_system.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Required(ErrorMessage = "*")]
        public string email { get; set; }
        public string Password { get; set; }
        public int grade { get; set; }

        [ForeignKey("ins")]
        public int? ins_id { get; set; } 
       public Instractor? ins { get; set; }
        public bool choice { get; set; }

        
    }
}
