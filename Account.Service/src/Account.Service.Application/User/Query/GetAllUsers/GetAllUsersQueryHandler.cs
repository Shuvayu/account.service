using Account.Service.Application.User.Model;
using Account.Service.Persistence;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Account.Service.Application.User.Query.GetAllUsers
{
    public class GetAllUsersQueryHandler : IRequestHandler<GetAllUserQuery, List<UserDto>>
    {
        private readonly AccountDbContext _context;

        private readonly IMapper _mapper;

        public GetAllUsersQueryHandler(AccountDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<UserDto>> Handle(GetAllUserQuery request, CancellationToken cancellationToken)
        {
            var userList = await _context.User.Where(u => u.IsActive == true).ToListAsync();
            return _mapper.Map<List<UserDto>>(userList);
        }
    }
}
