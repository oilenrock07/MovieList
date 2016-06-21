using System.ComponentModel.DataAnnotations.Schema;

namespace MovieList.Entities
{
    public class StarRole
    {
        public int StarRoleId { get; set; }

        [ForeignKey("Movie")]
        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }

        [ForeignKey("Person")]
        public int PersonId { get; set; }
        public Person Person { get; set; }

        public string Role { get; set; }
    }
}
