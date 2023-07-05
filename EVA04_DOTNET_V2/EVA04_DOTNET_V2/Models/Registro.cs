using System.ComponentModel.DataAnnotations;

namespace EVA04_DOTNET_V2.Models
{
    public class Registro
    {

        [Required(ErrorMessage = "MAIL ERROR")]
        public string Email { get; set; }


        [Required(ErrorMessage = "PASS ERROR")]
        [StringLength(50, ErrorMessage = "PASS LENGHT ERROR", MinimumLength = 5)]
        [DataType(DataType.Password)]
        [Display(Name = "PasswordOne")]
        public string Password { get; set; }


        [Required(ErrorMessage = "PASSWORDCONFIRMED ERROR")]
        [Compare("Password", ErrorMessage = "PASSWORDS DONT MATCH")]
        [DataType(DataType.Password)]
        [Display(Name = "PasswordOne")]
        public string ConfirmPassword { get; set; }


        [Required(ErrorMessage = "NAME ERROR")]
        public string Nombre { get; set; }


        [Required(ErrorMessage = "LASTNAME ERROR")]
        public string Apellido { get; set; }


    }
}
