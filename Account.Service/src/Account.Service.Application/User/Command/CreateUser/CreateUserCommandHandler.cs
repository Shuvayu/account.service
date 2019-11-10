using Account.Service.Application.Common.Exceptions;
using Account.Service.Application.User.Model;
using Account.Service.Persistence;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Account.Service.Application.User.Command.CreateUser
{
    class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, UserDto>
    {
        private readonly AccountDbContext _context;

        private readonly IMapper _mapper;

        public CreateUserCommandHandler(AccountDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<UserDto> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            // TODO : Add Duplicate Detection

            var userToAdd = _mapper.Map<Domain.Entities.User>(request);
            _context.User.Add(userToAdd);
            await _context.SaveChangesAsync();
            
            var userFound = await _context.User.Where(x => x.Email == request.Email).FirstOrDefaultAsync();
            return _mapper.Map<UserDto>(userFound);
        }
    }
}
