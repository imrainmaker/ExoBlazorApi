using Blazor.API.Enum;

namespace Blazor.API.Entities
{
    public class User
    {
        public int? Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string? Password { get; set; }
        public RoleEnum Role { get; set; } = RoleEnum.user;
    }
}
