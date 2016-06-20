using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieList.Entities
{
    public class MovieKeyword
    {
        [Key]
        public int MovieKeywordId { get; set; }

        [ForeignKey("Movie")]
        public int MovieId { get; set; }
        public virtual Movie Movie{ get; set; }

        public string Keyword { get; set; }
    }
}
