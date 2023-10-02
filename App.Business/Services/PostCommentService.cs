using App.Core.Models;
using App.Core.Persistence;
using App.Core.Service;
using App.Persistence;

namespace App.Business.Services
{
	public class PostCommentService : Service<PostComment>, IPostCommentService
	{
		public PostCommentService(IGenericPersistence<PostComment> persistence, AppDbContext context) : base(persistence, context)
		{
		}
	}
}
