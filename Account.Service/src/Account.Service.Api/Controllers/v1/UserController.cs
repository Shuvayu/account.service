using Account.Service.Application.Common.Query;
using Account.Service.Application.User.Command.CreateUser;
using Account.Service.Application.User.Model;
using Account.Service.Application.User.Query.GetAllUsers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Account.Service.Api.Controllers.v1
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class UserController : BaseController
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{id}", Name = "Get")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var query = new GetQuery<UserDto> { Id = id };
            return Ok(await Mediator.Send(query));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var query = new GetAllUserQuery();
            return Ok(await Mediator.Send(query));
        }


        [HttpPut]
        public async Task<IActionResult> PutAsync(CreateUserCommand createUserCommand)
        {
            var user = await Mediator.Send(createUserCommand);

            if (user == null)
            {
                return BadRequest();
            }
            else
            {
                return Created(new Uri($"{Request.Host.Value}/{user.UserId}"), user);
            }
        }
    }
}
