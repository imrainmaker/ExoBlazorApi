using Blazor.DAL.Context;
using Blazor.DAL.Entities;
using Blazor.DAL.Repositories;

namespace Blazor.DAL.Services
{
    public class UserService : IUserRepository
    {
        private readonly DataContext _service;

        public UserService(DataContext service)
        {
            _service = service;
        }

        public IEnumerable<User> GetAll()
        {
            return _service.Users.ToList();
        }
    }
}
