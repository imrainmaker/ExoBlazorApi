using System.ComponentModel.DataAnnotations;

namespace Blazor.API.Dtos
{
    public class UserLogin
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
