﻿using Account.Service.Application.User.Command.CreateUser;
using AutoMapper;
using System;

namespace Account.Service.Application.User.Mapper
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<CreateUserCommand , Domain.Entities.User>()
                .ForMember(dest => dest.UpdatedDate, opts => opts.MapFrom(_ => DateTime.UtcNow))
                .ForMember(dest => dest.CreatedDate, opts => opts.MapFrom(_ => DateTime.UtcNow))
                .ForMember(dest => dest.IsActive, opts => opts.MapFrom(_ => true));
        }
    }
}
