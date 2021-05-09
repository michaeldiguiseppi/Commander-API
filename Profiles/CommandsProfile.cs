using AutoMapper;
using Commander_API.Dtos;
using Commander_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commander_API.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            // Source -> Target/Destination
            CreateMap<Command, CommandReadDto>();
            // Target/Destination -> Source
            CreateMap<CommandCreateDto, Command>();
        }
    }
}
