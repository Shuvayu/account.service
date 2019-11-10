using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Account.Service.Application.Common.Exceptions;
using Account.Service.Application.Common.Query;
using Account.Service.Application.User.Model;
using Account.Service.Persistence;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Account.Service.Application.User.Query.GetUser
{
    public class GetUserQueryHandler : IRequestHandler<GetQuery<UserDto>, UserDto>
    {
        private readonly AccountDbContext _context;

        private readonly IMapper _mapper;

        public GetUserQueryHandler(AccountDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<UserDto> Handle(GetQuery<UserDto> request, CancellationToken cancellationToken)
        {
            var user = await _context.User.Where(x => x.UserId == request.Id && x.IsActive == true).FirstOrDefaultAsync();
            if (user == null)
            {
                throw new NotFoundException(nameof(User), request.Id);
            }
            return _mapper.Map<UserDto>(user);
        }
    }
}
