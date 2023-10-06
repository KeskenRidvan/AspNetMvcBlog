using App.Business.DTOs.Categories;
using App.Core.Models;
using AutoMapper;

namespace App.Business.AutoMapper.Categories
{
	public class CategoryProfile : Profile
	{
		public CategoryProfile()
		{
			CreateMap<CategoryDto, Category>().ReverseMap();
			CreateMap<ViewCategoryDto, Category>().ReverseMap();
			CreateMap<CreateOrEditCategoryDto, Category>().ReverseMap();
		}
	}
}
