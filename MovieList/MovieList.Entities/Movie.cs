using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieList.Entities
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }

        public string ImdbId { get; set; }
        public string Trailer { get; set; }
        public string Photos { get; set; }

        public string Title { get; set; }
        public int Year { get; set; }
        
        public double Rate { get; set; }
        public string Runtime { get; set; }
        public string Rating { get; set; }
        public string Summary { get; set; }
        public string StoryLine { get; set; }

        public int MetaScore { get; set; }
        public string ReviewLink { get; set; }
        public string AwardsLink { get; set; }
        public string Country { get; set; }
        public string Language { get; set; }
        public string ReleasedDate { get; set; }

        public string Budget { get; set; }
        public string Gross { get; set; }

        //public IEnumerable<string> Keywords { get; set; }

        //public string RelatedMovies { get; set; }

        public IEnumerable<Person> Writers { get; set; }
        public IEnumerable<Person> Stars { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
    }
}
