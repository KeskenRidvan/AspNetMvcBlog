using App.Business.DTOs.Pages;
using App.Core.Models;
using AutoMapper;

namespace App.Business.AutoMapper.Pages
{
	public class PageProfile : Profile
	{
		public PageProfile()
		{
			CreateMap<PageDto, Page>().ReverseMap();
			CreateMap<ViewPageDto, Page>().ReverseMap();
			CreateMap<CreateOrEditPageDto, Page>().ReverseMap();
		}
	}
}
