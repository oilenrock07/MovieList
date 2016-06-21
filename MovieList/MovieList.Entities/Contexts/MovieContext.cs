using System.Configuration;
using System.Data.Entity;

namespace MovieList.Entities.Contexts
{
    public class MovieContext : DbContext
    {
        public MovieContext()
            : base(ConnectionString)
        {
            Database.SetInitializer<MovieContext>(null);
        }

        public virtual IDbSet<Movie> Movies { get; set; }
        public virtual IDbSet<MovieKeyword> MovieKeywords  { get; set; }
        public virtual IDbSet<Genre> Genres  { get; set; }
        public virtual IDbSet<Person> Persons  { get; set; }
        public virtual IDbSet<RelatedMovie> RelatedMovies  { get; set; }
        public virtual IDbSet<StarRole> StarRoles { get; set; }

        public static string ConnectionString
        {
            get { return ConfigurationManager.ConnectionStrings["MovieConnectionString"].ConnectionString; }
        }
    }
}
