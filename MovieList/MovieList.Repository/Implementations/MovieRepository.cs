using MovieList.Architecture.Interfaces;
using MovieList.Entities;
using MovieList.Repository.Interfaces;
using MovieList.Architecture.Implementations;

namespace MovieList.Repository.Implementations
{
    public class MovieRepository : Repository<Movie>, IMovieRepository
    {
        public MovieRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
            DbSet = databaseFactory.GetDatabaseContext().Movies;
        }
    }
}
