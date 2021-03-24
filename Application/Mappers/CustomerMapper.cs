using Application.ViewModels;
using AutoMapper;
using Gym.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Mappers
{
    public class CustomerMapper : Profile
    {
        public CustomerMapper()
        {
            CreateMap<Customer, CustomerViewModel>()
                .ForMember(c => c.Active, cv => cv.MapFrom(src => src.Active))
                .ForMember(c => c.Address, cv => cv.MapFrom(src => src.Address))
                .ForMember(c => c.Age, cv => cv.MapFrom(src => src.Age))
                .ForMember(c => c.Email, cv => cv.MapFrom(src => src.Email))
                .ForMember(c => c.FirstName, cv => cv.MapFrom(src => src.FirstName))
                .ForMember(c => c.LastName, cv => cv.MapFrom(src => src.LastName))
                .ForMember(c => c.MiddleName, cv => cv.MapFrom(src => src.MiddleName))
                .ForMember(c => c.Name, cv => cv.MapFrom(src => src.Name))
                .ForMember(c => c.PrimaryPhone, cv => cv.MapFrom(src => src.PrimaryPhone))
                .ForMember(c => c.SecondaryPhone, cv => cv.MapFrom(src => src.SecondaryPhone))
                .ForMember(c => c.Weight, cv => cv.MapFrom(src => src.Weight))
                .ForMember(c => c.ZipCode, cv => cv.MapFrom(src => src.ZipCode));
        }
    }
}
