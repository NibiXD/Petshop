using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Petshop.Domain.Entities;
using Petshop.Domain.Interfaces.Services;
using Petshop.Service.Validators;

namespace Petshop.Application.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_userService.GetAll());
        }

        [HttpGet]
        public IActionResult Get(int id)
        {
            return Ok(_userService.Get(id));
        }

        [HttpPost]
        public IActionResult Create([FromBody] User user)
        {
            var entityAdded = _userService.Add(user);
            return CreatedAtAction(nameof(User), entityAdded);
        }

        [HttpPatch]
        public IActionResult Update([FromBody] User user)
        {
            _userService.BeforeUpdate<UserValidator>(user);
            return Ok();
        }
    }
}
