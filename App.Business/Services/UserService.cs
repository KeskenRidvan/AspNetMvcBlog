using App.Core.Models;
using App.Core.Persistence;
using App.Core.Service;
using App.Persistence;

namespace App.Business.Services
{
	public class UserService : Service<User>, IUserService
	{
		public UserService(IGenericPersistence<User> persistence, AppDbContext context) : base(persistence, context)
		{
		}
	}
}
