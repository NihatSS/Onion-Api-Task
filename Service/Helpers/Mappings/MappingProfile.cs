using AutoMapper;
using Domain.Entities;
using Service.Helpers.DTOs.Categories;

namespace Service.Helpers.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region Categories
            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryCreateDto, Category>();
            #endregion

        }
    }
}
    