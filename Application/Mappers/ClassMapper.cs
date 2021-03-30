using Application.ViewModels;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Mappers
{
    public class ClassMapper : Profile

    {
        public ClassMapper()
        {
            CreateMap<Class, ClassViewModel>()
                .ForMember(c => c.CreatedDate, cv => cv.MapFrom(src => src.CreatedDate))
                .ForMember(c => c.Name, cv => cv.MapFrom(src => src.Name))
                .ForMember(c => c.Description, cv => cv.MapFrom(src => src.Description));
        }
    }
}
