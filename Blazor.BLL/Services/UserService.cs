using Blazor.BLL.Entities;
using Blazor.DAL.Repositories;
using System;
using System.Collections.Generic;
using Blazor.BLL.Mappers;
using Blazor.BLL.Interfaces;

namespace Blazor.BLL.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _service;
        public UserService(IUserRepository service)
        {
            _service = service;
        }

        public IEnumerable<User> GetAll()
        {
            return _service.GetAll()?.ToList().ToBLLList();
        }
    }
}
