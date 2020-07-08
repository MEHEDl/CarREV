using AutoMapper;
using CarREV.Controllers.Resources;
using CarREV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarREV.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Make, MakeResource>();
            CreateMap<Feature, KeyValuePairResource>();
            CreateMap<Model, ModelResource>();
        }
    }
}
