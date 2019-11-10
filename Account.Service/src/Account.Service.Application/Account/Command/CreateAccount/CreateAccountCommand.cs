using Account.Service.Application.Account.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Account.Service.Application.Account.Command.CreateAccount
{
    public class CreateAccountCommand : IRequest<AccountDto>
    {
        public int UserId { get; set; }

        public string AccountType { get; set; }
    }
}
