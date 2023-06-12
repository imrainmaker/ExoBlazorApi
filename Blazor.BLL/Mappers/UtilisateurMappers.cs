using Blazor.BLL.Entities;
using Blazor.DAL.Dtos;
using DALUser = Blazor.DAL.Entities.User;

namespace Blazor.BLL.Mappers
{
    public static class UtilisateurMappers
    {
        public static UserDto ToUserDTO(this User userDto)
        {
            return
            new UserDto
            {
                Id = userDto.Id,
                Nom = userDto.Nom,
                Prenom = userDto.Prenom,
                Email = userDto.Email,
                Password = userDto.Password,
                Role = (DAL.Enum.RoleEnum)userDto.Role,
            };
        }
        public static User ToBLL(this DALUser userDal)
        {
            return
            new User
            {
                Id = userDal.Id,
                Nom = userDal.Nom,
                Prenom = userDal.Prenom,
                Email = userDal.Email,
                Role = (Enum.RoleEnum)userDal.Role,
            };
        }
        public static async Task<User> ToBLL(this Task<DALUser> userTask)
        {
            DALUser userDal = await userTask;
            return
            new User
            {
                Id = userDal.Id,
                Nom = userDal.Nom,
                Prenom = userDal.Prenom,
                Email = userDal.Email,
                Role = (Enum.RoleEnum)userDal.Role,
            };
        }

        public static async Task<List<User>> ToBLLList(this Task<IEnumerable<DALUser>> usersTask)
        {
            IEnumerable<DALUser> DalUsers = await usersTask;
            List<User> list = new List<User>();
            foreach (DALUser user in DalUsers)
            {
                list.Add(ToBLL(user));
            }

            return list;
        }
    }
}
