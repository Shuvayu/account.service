using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Account.Service.Api.v1.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly ILogger<AccountController> _logger;

        public AccountController(ILogger<AccountController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
          return Ok("Get From Account");
        }
    }
}
