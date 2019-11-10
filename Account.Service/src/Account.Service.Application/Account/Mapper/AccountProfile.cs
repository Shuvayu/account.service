using Account.Service.Application.Account.Command.CreateAccount;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Account.Service.Application.Account.Mapper
{
    public class AccountProfile : Profile
    {
        public AccountProfile()
        {
            CreateMap<CreateAccountCommand, Domain.Entities.Account>()
                .ForMember(dest => dest.UpdatedDate, opts => opts.MapFrom(_ => DateTime.UtcNow))
                .ForMember(dest => dest.CreatedDate, opts => opts.MapFrom(_ => DateTime.UtcNow))
                .ForMember(dest => dest.IsActive, opts => opts.MapFrom(_ => true));
        }
    }
}
