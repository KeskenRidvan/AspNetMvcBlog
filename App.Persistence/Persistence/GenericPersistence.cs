using App.Core.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace App.Persistence.Persistence
{
	public class GenericPersistence<TEntity> : IGenericPersistence<TEntity> where TEntity : class, IEntity, new()
	{
		protected readonly AppDbContext _context;
		private readonly DbSet<TEntity> _dbSet;

		public GenericPersistence(AppDbContext context)
		{
			_context = context;
			_dbSet = _context.Set<TEntity>();
		}

		public async Task AddAsync(TEntity entity)
		{
			await _dbSet.AddAsync(entity);
		}

		public async Task AddRangeAsync(IEnumerable<TEntity> entities)
		{
			await _dbSet.AddRangeAsync(entities);
		}

		public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> expression)
		{
			return await _dbSet.AnyAsync(expression);
		}

		public IQueryable<TEntity> GetAll()
		{
			return _dbSet.AsNoTracking().AsQueryable();
		}

		public async Task<TEntity> GetByIdAsync(int id)
		{
			return await _dbSet.FindAsync(id);
		}

		public void Remove(TEntity entity)
		{
			_dbSet.Remove(entity);
		}

		public void RemoveRange(IEnumerable<TEntity> entities)
		{
			_dbSet.RemoveRange(entities);
		}

		public void Update(TEntity entity)
		{
			_dbSet.Update(entity);
		}

		public IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> expression)
		{
			return _dbSet.Where(expression);
		}
	}
}
