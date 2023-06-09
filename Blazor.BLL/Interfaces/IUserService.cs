using Blazor.BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.BLL.Interfaces
{
    public interface IUserService
    {
        IEnumerable<User> GetAll();
    }
}
