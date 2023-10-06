using App.Business.DTOs.Settings;
using App.Core.Models;
using AutoMapper;

namespace App.Business.AutoMapper.Settings
{
	public class SettingProfile : Profile
	{
		public SettingProfile()
		{
			CreateMap<CreateOrEditSettingDto, Setting>().ReverseMap();
			CreateMap<SettingDto, Setting>().ReverseMap();
			CreateMap<ViewSettingDto, Setting>().ReverseMap();
		}
	}
}
