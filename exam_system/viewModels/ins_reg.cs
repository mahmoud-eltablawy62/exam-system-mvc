using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace exam_system.viewModels
{
    
    public class ins_reg
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "*")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Name must be from 5 to 50 char")]
        public string Name { get; set; }
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress, ErrorMessage = "You must give a valid email")]
        [EmailAddress()]

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        [RegularExpression("^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z]).{8,32}$", ErrorMessage = "You must match regex At least one digit [0-9]\r\nAt least one lowercase character [a-z]\r\nAt least one uppercase character [A-Z] At least 8 characters in length, but no more than 32.")]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [RegularExpression("^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z]).{8,32}$", ErrorMessage = "You must match regex At least one digit [0-9]\r\nAt least one lowercase character [a-z]\r\nAt least one uppercase character [A-Z] At least 8 characters in length, but no more than 32.")]
        [Compare("Password", ErrorMessage = "Password must match confirm password")]
        public string confirm_password { get; set; }
    }
}
