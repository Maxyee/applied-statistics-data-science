using spondon.Domins;
using spondon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace spondon.Utilities
{
    public class MapperProfile : AutoMapper.Profile
    {
        public MapperProfile()
        {
            CreateMap<User, RegisterViewModel>()
                    .ReverseMap();
        }
    }
}
