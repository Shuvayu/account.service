using Account.Service.Application.Account.Model;
using MediatR;
using System.Collections.Generic;

namespace Account.Service.Application.Account.Query.GetAllAccounts
{
    public class GetAllAccountsQuery : IRequest<List<AccountDto>>
    {
    }
}
