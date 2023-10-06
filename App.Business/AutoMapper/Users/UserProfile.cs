using App.Business.DTOs.Users;
using App.Core.Models;
using AutoMapper;

namespace App.Business.AutoMapper.Users
{
	public class UserProfile : Profile
	{
		public UserProfile()
		{
			CreateMap<CreateOrEditUserDto, User>().ReverseMap();
			CreateMap<UserDto, User>().ReverseMap();
			CreateMap<ViewUserDto, User>().ReverseMap();
		}
	}
}
