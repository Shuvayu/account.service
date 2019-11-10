using Account.Service.Application.Account.Model;
using Account.Service.Application.Common.Exceptions;
using Account.Service.Persistence;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Account.Service.Application.Account.Command.CreateAccount
{
    public class CreateAccountCommandHandler : IRequestHandler<CreateAccountCommand, AccountDto>
    {
        private readonly AccountDbContext _context;

        private readonly IMapper _mapper;

        public CreateAccountCommandHandler(AccountDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<AccountDto> Handle(CreateAccountCommand request, CancellationToken cancellationToken)
        {
            // TODO : Add Duplicate Detection
            
            var accountToAdd = _mapper.Map<Domain.Entities.Account>(request);
            accountToAdd.User = await _context.User
                                                .Where(x => x.UserId == request.UserId && x.IsActive == true)
                                                .FirstOrDefaultAsync();

            // TODO: Add logic for when user not found
            _context.Account.Add(accountToAdd);
            await _context.SaveChangesAsync();

            var accountFound = await _context
                                        .Account
                                        .Include(inc => inc.User)
                                        .Where(x => x.User.UserId == request.UserId && x.AccountType == request.AccountType && x.IsActive == true)
                                        .FirstOrDefaultAsync();

            return _mapper.Map<AccountDto>(accountFound);
        }
    }
}
