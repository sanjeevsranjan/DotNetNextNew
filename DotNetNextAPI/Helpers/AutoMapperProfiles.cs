using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DotNetNextAPI.Dtos;
using DotNetNextAPI.Models;

namespace DotNetNextAPI.Helpers
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            
            CreateMap<UserForLoginDto, User>();
            CreateMap<UserForRegisterDto, User>();
            CreateMap<UserForListDto, User>();
            CreateMap<UserForDetailedDto, User>();
        }
    }
}
