using MovieList.Architecture.Interfaces;
using MovieList.Entities.Contexts;

namespace MovieList.Architecture.Implementations
{
    public class DatabaseFactory : IDatabaseFactory
    {
        private MovieContext _movieContext;
        
        public MovieContext GetDatabaseContext()
        {
            if (_movieContext != null)
                return _movieContext;

            return _movieContext = new MovieContext();
        }
    }
}
