using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp.AppServices.Mappings
{
    public class MappingProfile : AutoMapper.Profile
    {
        public MappingProfile()
        {
            CreateMap<DTOs.ToDoDTO, Domain.Entities.ToDo>().ReverseMap();
            CreateMap<DTOs.ToDoFilterDTO, Domain.Filters.ToDoFilter>().ReverseMap();
        }
    }
}
