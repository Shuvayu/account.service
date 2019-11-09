using Account.Service.Api.Controllers.v1;
using Account.Service.Application.Common.Query;
using Account.Service.Application.User.Model;
using Account.Service.Application.User.Query.GetAllUsers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Account.Service.Api.v1.Controllers
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
    }
}
