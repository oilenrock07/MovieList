using MovieList.Architecture.Interfaces;
using MovieList.Entities.Contexts;

namespace MovieList.Architecture.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MovieContext _context;

        public UnitOfWork(IDatabaseFactory databaseFactory)
        {
            _context = databaseFactory.GetDatabaseContext();
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
