using App.Core.Models;
using App.Core.Persistence;

namespace App.Persistence.Persistence
{
	public class PostPersistence : GenericPersistence<Post>, IPostPersistence
	{
		public PostPersistence(AppDbContext context) : base(context)
		{
		}
	}
}
