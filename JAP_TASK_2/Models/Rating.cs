namespace JAP_TASK_2.Models
{
    public class Rating
    {
        public int Id { get; set; }
        public double Value { get; set; }
        public Movie RatedMovie { get; set; }
        public int RatedMovieId { get; set; }
        public User User { get; set; }
    }
}