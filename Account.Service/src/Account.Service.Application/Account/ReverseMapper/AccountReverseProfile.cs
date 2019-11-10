using Account.Service.Application.Account.Model;
using AutoMapper;

namespace Account.Service.Application.Account.ReverseMapper
{
    public class AccountReverseProfile : Profile
    {
        public AccountReverseProfile()
        {
            CreateMap<Domain.Entities.Account, AccountDto>();
        }
    }
}
