using App.Core.Models;
using App.Core.Persistence;
using App.Core.Service;
using App.Persistence;

namespace App.Business.Services
{
	public class PageService : Service<Page>, IPageService
	{
		public PageService(IGenericPersistence<Page> persistence, AppDbContext context) : base(persistence, context)
		{
		}
	}
}
