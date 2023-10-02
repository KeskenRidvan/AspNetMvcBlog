using App.Core.Models;
using App.Core.Persistence;

namespace App.Persistence.Persistence
{
	public class UserPersistence : GenericPersistence<User>, IUserPersistence
	{
		public UserPersistence(AppDbContext context) : base(context)
		{
		}
	}
}
