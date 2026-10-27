namespace OOP_task1
{
    public class Movie
    {
        public string Title { get; }
        public int DurationMinutes { get; }

        public Movie(string title, int durationMinutes)
        {
            Title = title;
            DurationMinutes = durationMinutes;
        }
    }
}
