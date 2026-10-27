namespace OOP_task1
{
    public class Cinema(string name, string address)
    {
        private List<Hall> _halls = new List<Hall>();
        private List<Movie> _films = new List<Movie>();
        public string Name { get; } = name;
        public string Address { get; } = address;

        public void AddMovie(Movie movie)
        {
            _films.Add(movie);
        }

        public void AddHall(Hall hall)
        {
            _halls.Add(hall);
        }
    }
}
