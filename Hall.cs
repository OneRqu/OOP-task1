namespace OOP_task1
{
    public class Hall(int number)
    {
        private List<Seat> _seats = new List<Seat>();
        public int Number { get; } = number;

        public void AddSeat(Seat seat)
        {
            _seats.Add(seat);
        }

        public void RemoveSeat(Seat seat)
        {
            _seats.Remove(seat);
        }

        public void Clean()
        {
            _seats = new List<Seat>();
        }
    }
}
