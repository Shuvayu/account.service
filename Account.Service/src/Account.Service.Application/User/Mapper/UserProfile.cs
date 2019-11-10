using Account.Service.Application.User.Command.CreateUser;
using AutoMapper;

namespace Account.Service.Application.User.Mapper
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<CreateUserCommand , Domain.Entities.User>();
        }
    }
}
