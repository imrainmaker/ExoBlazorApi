using Blazor.BLL.Entities;
using Blazor.DAL.Repositories;
using System;
using System.Collections.Generic;
using Blazor.BLL.Mappers;
using Blazor.BLL.Interfaces;
using Blazor.DAL.Dtos;

namespace Blazor.BLL.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _service;
        public UserService(IUserRepository service)
        {
            _service = service;
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            IEnumerable<User>? users = await _service.GetAll()?.ToBLLList();
            return users;
        }

        public async Task<User> AddUser(User user)
        {
            User NewUser = await _service.AddUser(user.ToUserDTO()).ToBLL();
            return NewUser;
        }
    }
}
