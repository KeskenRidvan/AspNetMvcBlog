using App.Core.Models;
using App.Core.Persistence;

namespace App.Persistence.Persistence
{
	public class PostImagePersistence : GenericPersistence<PostImage>, IPostImagePersistence
	{
		public PostImagePersistence(AppDbContext context) : base(context)
		{
		}
	}
}
