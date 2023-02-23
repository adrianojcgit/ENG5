using AutoMapper;
using ENG5.Application.DTOs;
using ENG5.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ENG5.Application.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<Product, ProductDTO>().ReverseMap();
            CreateMap<Category, CategoryDTO>().ReverseMap();
        }
    }
}
