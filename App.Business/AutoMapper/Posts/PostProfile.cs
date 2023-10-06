using App.Business.DTOs.Posts;
using App.Core.Models;
using AutoMapper;

namespace App.Business.AutoMapper.Posts
{
	public class PostProfile : Profile
	{
		public PostProfile()
		{
			CreateMap<PostDto, Post>().ReverseMap();
			CreateMap<ViewPostDto, Post>().ReverseMap();
			CreateMap<CreateOrEditPostDto, Post>().ReverseMap();
		}
	}
}
