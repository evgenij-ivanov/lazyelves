using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Data.Models.Interfaces;
using System.Linq.Expressions;

namespace Data.Repositories.Interfaces
{
    interface IRepository<TEntity, TId> where TEntity : class, IEntityWithId<TId>
    {

        IQueryable<TEntity> All();

        TEntity Create(TEntity t);

        void Create(IEnumerable<TEntity> items);

        void Update(TEntity t);

        void Delete(TEntity entity);

        void Delete(Expression<Func<TEntity, bool>> predicate);

        void Delete(IEnumerable<TEntity> entities);

        IQueryable<TEntity> Filter(Expression<Func<TEntity, bool>> predicate);

        Task<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate);

        int Count { get; }

        TEntity Detach(TEntity entry);
    }
}
