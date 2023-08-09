using System.ComponentModel.DataAnnotations.Schema;

namespace exam_system.Models
{
    public class Exam
    {
        public int Id { get; set; }
        [ForeignKey("Ques")]
        public int Ques_id {get ; set; }    
        public Quesions Ques { get; set; }

    }
}
