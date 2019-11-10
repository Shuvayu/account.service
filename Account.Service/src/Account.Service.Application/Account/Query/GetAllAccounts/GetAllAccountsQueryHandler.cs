using Account.Service.Application.Account.Model;
using Account.Service.Persistence;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Account.Service.Application.Account.Query.GetAllAccounts
{
    public class GetAllAccountsQueryHandler : IRequestHandler<GetAllAccountsQuery, List<AccountDto>>
    {
        private readonly AccountDbContext _context;

        private readonly IMapper _mapper;

        public GetAllAccountsQueryHandler(AccountDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<AccountDto>> Handle(GetAllAccountsQuery request, CancellationToken cancellationToken)
        {
            var accountList = await _context
                                        .Account
                                        .Include(inc => inc.User)
                                        .ToListAsync();
            return _mapper.Map<List<AccountDto>>(accountList);
        }
    }
}
