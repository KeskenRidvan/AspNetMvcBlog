using System.Linq.Expressions;

namespace App.Core.Persistence
{
	public interface IGenericPersistence<TEntity> where TEntity : class, IEntity, new()
	{
		Task<TEntity> GetByIdAsync(int id);
		IQueryable<TEntity> GetAll();
		IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> expression);
		Task<bool> AnyAsync(Expression<Func<TEntity, bool>> expression);
		Task AddAsync(TEntity entity);
		Task AddRangeAsync(IEnumerable<TEntity> entities);
		void Update(TEntity entity);
		void Remove(TEntity entity);
		void RemoveRange(IEnumerable<TEntity> entities);
	}
}
