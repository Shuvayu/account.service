using System.Threading;
using System.Threading.Tasks;
using Account.Service.Application.Common.Query;
using Account.Service.Application.User.Model;
using MediatR;

namespace Account.Service.Application.User.Query.GetUser
{
    public class GetUserQueryHandler : IRequestHandler<GetQuery<UserDto>, UserDto>
    {
        public Task<UserDto> Handle(GetQuery<UserDto> request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
