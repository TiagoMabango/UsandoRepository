using AutoMapper;
using Xyami.Core.DTOs;
using Xyami.Core.Entities;

namespace Xyami.API.Helpers
{
    public class AutProfile : Profile
    {
        public AutProfile()
        {
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<Category, CategoryDTOAll>().ReverseMap();
            CreateMap<Category, CategoryListDTO>().ReverseMap();

            CreateMap<Family, FamilyCreatDTO>().ReverseMap();
            CreateMap<Family, FamilyDTO>().ReverseMap();
            CreateMap<Family, FamilyListDTO>().ReverseMap();

            CreateMap<Product, ProductCreatDTO>().ReverseMap();
            CreateMap<Product, ProductDTO>().ReverseMap();
        }
    }
}
