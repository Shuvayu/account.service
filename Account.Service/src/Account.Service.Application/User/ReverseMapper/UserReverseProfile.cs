using Account.Service.Application.User.Model;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Account.Service.Application.User.ReverseMapper
{
    public class UserReverseProfile : Profile
    {
        public UserReverseProfile()
        {
            CreateMap<Domain.Entities.User, UserDto>();
        }
    }
}
