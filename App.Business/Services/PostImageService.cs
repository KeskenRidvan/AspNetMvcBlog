using App.Core.Models;
using App.Core.Persistence;
using App.Core.Service;
using App.Persistence;

namespace App.Business.Services
{
	public class PostImageService : Service<PostImage>, IPostImageService
	{
		public PostImageService(IGenericPersistence<PostImage> persistence, AppDbContext context) : base(persistence, context)
		{
		}
	}
}
