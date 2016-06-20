
using System.ComponentModel.DataAnnotations;

namespace MovieList.Entities
{
    public class Person
    {
        [Key]
        public string PersonId { get; set; }
        public string FullName { get; set; }
        public string ImdbPersonId { get; set; }
    }
}
