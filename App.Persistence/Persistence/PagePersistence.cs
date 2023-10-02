using App.Core.Models;
using App.Core.Persistence;

namespace App.Persistence.Persistence
{
	public class PagePersistence : GenericPersistence<Page>, IPagePersistence
	{
		public PagePersistence(AppDbContext context) : base(context)
		{
		}
	}
}
