using System;
using System.Collections.Generic;

namespace KingCraft.Contracts.Persistence.Repositories
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();

        IEnumerable<T> GetAll(Func<T, bool> predicate);

        T GetById(int id);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}