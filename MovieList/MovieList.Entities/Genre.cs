using System.ComponentModel.DataAnnotations;

namespace MovieList.Entities
{
    public class Genre
    {
        [Key]
        public int GenreId { get; set; }
        public string GenreName { get; set; }
    }
}
