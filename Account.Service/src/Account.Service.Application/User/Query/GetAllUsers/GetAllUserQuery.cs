using Account.Service.Application.User.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Account.Service.Application.User.Query.GetAllUsers
{
    public class GetAllUserQuery : IRequest<List<UserDto>>
    {
    }
}
