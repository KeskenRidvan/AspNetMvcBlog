
using App.Core.Models;
using App.Core.Persistence;
using App.Core.Service;
using App.Persistence;

namespace App.Business.Services
{
	public class CategoryService : Service<Category>, ICategoryService
	{
		public CategoryService(IGenericPersistence<Category> persistence, AppDbContext context) : base(persistence, context)
		{
		}
	}
}
