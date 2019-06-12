using AccountOwnerServer.Data.Contracts;
using AccountOwnerServer.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AccountOwnerServer.Data
{
    public class RepositoryBase<TEntity, TKey> : IRepository<TEntity, TKey> where TEntity : EntityBase<TKey>
    {

        private readonly RepositoryContext _dbContext;
        private readonly DbSet<TEntity> _dbSet;
        public RepositoryBase(RepositoryContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<TEntity>();
        }
        public void Add(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            _dbSet.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Deleted;
        }

        public async Task DeleteAsync(TKey id)
        {
            var entity = await GetAsync(id);
            Delete(entity);
        }

        public IQueryable<TEntity> GetAll(int skip, int take)
        {
            return _dbSet.OrderBy(q => q.Id).Skip(skip).Take(take);
        }

        public IQueryable<TEntity> GetAllByCondition(int skip, int take, Expression<Func<TEntity, bool>> predicate)
        {
            return GetAll(skip, take).Where(predicate);
        }

        public Task<TEntity> GetAsync(TKey id)
        {
            return _dbSet.FindAsync(id);
        }

        public void Update(TEntity entity)
        {
            _dbSet.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
        }
    }
}
