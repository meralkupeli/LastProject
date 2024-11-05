using ManagementDAL.Domain.Entity;
using ManagementDAL.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ManagementDAL.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {


        private readonly DbSet<T> _dbSet;
       

        public async Task AddAsync(T entity)
        {
            entity.Id = Guid.NewGuid();
            await _dbSet.AddAsync(entity);
        }

        public async Task AddRange(IEnumerable<T> entity)
        {
            await _dbSet.AddRangeAsync(entity);
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public async Task Delete(Guid id)
        {
            var entity = await GetById(id);

            _dbSet.Remove(entity);
        }

        public async Task Delete(Expression<Func<T, bool>> predicate)
        {
            var entity = await GetById(predicate);

            _dbSet.Remove(entity);
        }

        public void DeleteRange(List<T> entities)
        {
            _dbSet.RemoveRange(entities);
        }


        public async Task<List<T>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public IQueryable<T> GetAllQuery()
        {
            return _dbSet.AsNoTracking();
        }

        public async Task<List<T>> GetAll(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.Where(predicate).ToListAsync();
        }

        public async Task<T> GetById(Guid id)
        {
            return await _dbSet.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<T> GetById(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.FirstOrDefaultAsync(predicate);
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }

        public void UpdateRange(List<T> entity)
        {
            _dbSet.UpdateRange(entity);
        }


        public async Task<bool> AnyAsync(Expression<Func<T, bool>> expression)
        {
            return await _dbSet.AnyAsync(expression);
        }

        public Task<bool> Contains(T entity)
        {
            return _dbSet.ContainsAsync(entity);
        }

    }
}
