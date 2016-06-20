
using System;
using System.Linq;
using System.Linq.Expressions;

namespace MovieList.Architecture.Interfaces
{
    public interface IRepository<T> where T: class
    {
        IQueryable<T> Find(Expression<Func<T, bool>> expression);
        T Add(T model);
        T GetById(int id);
        void Update(T model);
        void Delete(T model);
    }
}
