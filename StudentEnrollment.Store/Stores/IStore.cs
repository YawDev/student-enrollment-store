using System;
using System.Collections.Generic;

namespace StudentEnrollment.Store.Stores
{
    public interface IStore<TEntity> where TEntity : class
    {
        TEntity Get(Guid id);
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
    }
}