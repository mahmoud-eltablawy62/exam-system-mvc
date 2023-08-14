using System.ComponentModel.DataAnnotations;

namespace exam_system.viewModels
{
    public class log_in
    {
        [DataType(DataType.EmailAddress, ErrorMessage = "You must give a valid email")]
        [Display(Name = "Email address")]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        [RegularExpression("^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z]).{8,32}$", ErrorMessage = "You must match regex At least one digit [0-9]\r\nAt least one lowercase character [a-z]\r\nAt least one uppercase character [A-Z] At least 8 characters in length, but no more than 32.")]
        public string Password { get; set; }
        public bool Id { get; set; }    
    }
}
