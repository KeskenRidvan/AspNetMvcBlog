using App.Core.Persistence;
using App.Core.Service;
using App.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace App.Business.Services
{
	public class Service<TEntity> : IService<TEntity> where TEntity : class, IEntity, new()
	{
		private readonly IGenericPersistence<TEntity> _persistence;
		private readonly AppDbContext _context;

		public Service(IGenericPersistence<TEntity> persistence, AppDbContext context)
		{
			_context = context;
			_persistence = persistence;
		}

		public async Task<TEntity> AddAsync(TEntity entity)
		{
			await _persistence.AddAsync(entity);
			await _context.SaveChangesAsync();

			return entity;
		}

		public async Task<IEnumerable<TEntity>> AddRangeAsync(IEnumerable<TEntity> entities)
		{
			await _persistence.AddRangeAsync(entities);
			await _context.SaveChangesAsync();
			return entities;
		}

		public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> expression)
		{
			return await _persistence.AnyAsync(expression);
		}

		public async Task<IEnumerable<TEntity>> GetAllAsync()
		{
			return await _persistence.GetAll().ToListAsync();
		}

		public async Task<TEntity> GetByIdAsync(int id)
		{
			return await _persistence.GetByIdAsync(id);
		}

		public async Task RemoveAsync(TEntity entity)
		{
			_persistence.Remove(entity);
			await _context.SaveChangesAsync();
		}

		public async Task RemoveRangeAsync(IEnumerable<TEntity> entities)
		{
			_persistence.RemoveRange(entities);
			await _context.SaveChangesAsync();
		}

		public async Task UpdateAsync(TEntity entity)
		{
			_persistence.Update(entity);
			await _context.SaveChangesAsync();
		}

		public IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> expression)
		{
			return _persistence.Where(expression);
		}
	}
}
