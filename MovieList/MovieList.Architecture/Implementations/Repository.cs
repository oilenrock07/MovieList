using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using MovieList.Architecture.Interfaces;
using MovieList.Entities.Contexts;

namespace MovieList.Architecture.Implementations
{
    public class Repository<T> : IRepository<T>
        where T : class
    {

        private readonly MovieContext _context;
        private IDbSet<T> _dbSet;

        public IDbSet<T> DbSet
        {
            get { return _dbSet ?? _context.Set<T>(); }
            set { _dbSet = value; }
        }
             
 
        public Repository(IDatabaseFactory databaseFactory)
        {
            _context = databaseFactory.GetDatabaseContext();
        }

        public virtual IQueryable<T> Find(Expression<Func<T, bool>> expression)
        {
            return DbSet.Where(expression);
        }

        public virtual T Add(T model)
        {
            return DbSet.Add(model);
        }

        public virtual T GetById(int id)
        {
            return DbSet.Find(id);
        }

        public virtual void Update(T model)
        {
            DbSet.Attach(model);
        }

        public virtual void Delete(T model)
        {
            DbSet.Remove(model);
        }
    }
}
