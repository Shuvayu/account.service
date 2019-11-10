using Account.Service.Application.Account.Command.CreateAccount;
using Account.Service.Application.Account.Query.GetAllAccounts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Account.Service.Api.Controllers.v1
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class AccountController : BaseController
    {
        private readonly ILogger<AccountController> _logger;

        public AccountController(ILogger<AccountController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var query = new GetAllAccountsQuery();
            return Ok(await Mediator.Send(query));
        }


        [HttpPut]
        public async Task<IActionResult> PutAsync(CreateAccountCommand createUserCommand)
        {
            var account = await Mediator.Send(createUserCommand);

            if (account == null)
            {
                return BadRequest();
            }
            else
            {
                return Created(new Uri($"{Request.Host.Value}/{account.AccountId}"), account);
            }
        }
    }
}
