using System.ComponentModel.DataAnnotations;

namespace Blazor.API.Dtos
{
    public class UserRegister
    {
        [Required]
        public string Nom { get; set; }
        [Required]
        public string Prenom { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&+=!]).{8,25}$")]
        public string Password { get; set; }
        [Required]
        [Compare("Password")]
        public string VerificationPassword { get; set; }
    }
}
