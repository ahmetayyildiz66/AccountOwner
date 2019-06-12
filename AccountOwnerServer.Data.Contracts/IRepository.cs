using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AccountOwnerServer.Data.Contracts
{
    public interface IRepository<TEntity,TKey> where TEntity: class
    {
        IQueryable<TEntity> GetAll(int skip, int take);
        IQueryable<TEntity> GetAllByCondition(int skip, int take, Expression<Func<TEntity, bool>> predicate);
        Task<TEntity> GetAsync(TKey id);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        Task DeleteAsync(TKey id);
    }
}
