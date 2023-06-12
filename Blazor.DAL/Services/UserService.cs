using Blazor.DAL.Context;
using Blazor.DAL.Entities;
using Blazor.DAL.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Blazor.DAL.Services
{
    public class UserService : IUserRepository
    {
        private readonly DataContext _service;

        public UserService(DataContext service)
        {
            _service = service;
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await _service.Users.ToListAsync();
        }
    }
}
