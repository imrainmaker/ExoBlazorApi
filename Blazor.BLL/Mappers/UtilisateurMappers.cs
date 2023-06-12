using Blazor.BLL.Entities;
using DALUser = Blazor.DAL.Entities.User;

namespace Blazor.BLL.Mappers
{
    public static class UtilisateurMappers
    {
        public static User ToBLL(this DALUser user)
        {
            return
            new User
            {
                Id = user.Id,
                Nom = user.Nom,
                Prenom = user.Prenom,
                Email = user.Email,
                Password = user.Password,
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
