using AutoMapper;
using CategoryService.Dtos;
using CategoryService.Models;

namespace CategoryService.Profiles
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<Category, CategoryReadDto>();
            CreateMap<CategoryCreateDto, Category>();
        }
    }
}