using Blazor.DAL.Enum;

namespace Blazor.DAL.Entities
{
    public class User
    {
        public string Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public RoleEnum Role { get; set; } = RoleEnum.user;
    }
}
