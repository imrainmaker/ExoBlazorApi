using Blazor.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.DAL.Repositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAll();
    }
}
