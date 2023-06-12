using Blazor.API.Dtos;
using Blazor.API.Entities;
using UserBLL = Blazor.BLL.Entities.User;

namespace Blazor.API.Mappers
{
    public static class UtilisateurMapper
    {
        public static UserBLL ToBLL(this UserRegister userRegister)
        {
            return new UserBLL
            {
                Email = userRegister.Email,
                Nom = userRegister.Nom,
                Prenom = userRegister.Prenom,
                Password = userRegister.Password,
                Role = (BLL.Enum.RoleEnum)Enum.RoleEnum.user,

            };
        }

        public static async Task<User> ToUser(this Task<UserBLL> userTask)
        {
            UserBLL userRegister = await userTask;
            return new User
            {
                Id = userRegister.Id,
                Email = userRegister.Email,
                Nom = userRegister.Nom,
                Prenom = userRegister.Prenom,
                Password = userRegister.Password,
                Role = Enum.RoleEnum.user,

            };
        }
    }
}
