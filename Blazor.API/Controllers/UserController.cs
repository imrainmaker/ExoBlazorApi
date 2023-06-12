using Blazor.API.Dtos;
using Blazor.API.Entities;
using Blazor.API.Mappers;
using Blazor.BLL.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blazor.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetAll() 
        { 
            
            return Ok(await _service.GetAll());
        }

        [HttpPost]
        public async Task<ActionResult<User>> AddUser(UserRegister user)
        {
            User? newUser = await _service.AddUser(user.ToBLL()).ToUser();

            return newUser is not null ? Ok(newUser) : BadRequest();
        }
    }
}
