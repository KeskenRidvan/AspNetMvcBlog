using App.Core.Models;
using App.Core.Persistence;
using App.Core.Service;
using App.Persistence;

namespace App.Business.Services
{
	public class PostService : Service<Post>, IPostService
	{
		public PostService(IGenericPersistence<Post> persistence, AppDbContext context) : base(persistence, context)
		{
		}
	}
}
