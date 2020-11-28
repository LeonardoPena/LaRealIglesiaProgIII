using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EsteEs.Models;
using EsteEs.ViewModels;
using AutoMapper;
namespace EsteEs.AutoMapper
{
    public class Automapping : Profile
    {
        public Automapping()
        {
            MapearIntegrantes();
        }

        public void MapearIntegrantes()
        {
            CreateMap<Integrantes, DetallesViewModel>().ReverseMap();
           // .ForMember(dest => dest.Campo, opt => opt.Ignore())
       // .ForMember(dest => dest.Campo, opt => opt.Ignore());
        }
    }
}
