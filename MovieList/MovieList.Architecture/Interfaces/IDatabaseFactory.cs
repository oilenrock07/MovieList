using MovieList.Entities.Contexts;

namespace MovieList.Architecture.Interfaces
{
    public interface IDatabaseFactory
    {
        MovieContext GetDatabaseContext();
    }
}
