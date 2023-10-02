using App.Core.Models;
using App.Core.Persistence;

namespace App.Persistence.Persistence
{
	public class PostCommentPersistence : GenericPersistence<PostComment>, IPostCommentPersistence
	{
		public PostCommentPersistence(AppDbContext context) : base(context)
		{
		}
	}
}
