using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieList.Entities
{
    public class RelatedMovie
    {
        [Key]
        public int RelatedMovieId { get; set; }

        [ForeignKey("Movie")]
        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }
        
        public string ImdbId { get; set; }
    }
}
