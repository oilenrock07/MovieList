using MovieList.Entities;

namespace MovieList.Models.Maintenance
{
    public class MaintenanceViewModel
    {
        public MaintenanceViewModel()
        {
            Movie = new Movie();
        }

        public Movie Movie { get; set; }

        //for create and update
        public string WriterRaw { get; set; }
        public string StarsRaw { get; set; }
        public string GenreRaw { get; set; }
    }
}