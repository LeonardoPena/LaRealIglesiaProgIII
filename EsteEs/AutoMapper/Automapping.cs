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
            MapearSl();
        }

        public void MapearSl()
        {
            CreateMap<DatosEclesiasticos, DatosEclesiasticos>().ReverseMap().
            ForMember(dest => dest.Id, opt => opt.Ignore())
       .ForMember(dest => dest.IdIntegrante, opt => opt.Ignore());
        }


    }
}
