using App.Core.Models;
using App.Core.Persistence;

namespace App.Persistence.Persistence
{
	public class CategoryPersistence : GenericPersistence<Category>, ICategoryPersistence
	{
		public CategoryPersistence(AppDbContext context) : base(context)
		{
		}
	}
}
