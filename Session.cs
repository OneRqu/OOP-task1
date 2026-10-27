namespace OOP_task1
{
    public class Session(string startTime, Movie movie, double price)
    {
        private Movie _movie = movie;
        private double _price = price;
        private List<Ticket> _soldTickets = new List<Ticket>();
        public string StartTime = startTime;

        public void AddTicket(Ticket ticket)
        {
            _soldTickets.Add(ticket);
        }

        public void ChangePrice(double price)
        {
            _price = price;
        }

        public bool IsSeatTaken(Seat seat)
        {
            return _soldTickets.Any(ticket => ticket.RowNumber == seat.Row && ticket.SeatNumber == seat.Number);
        }
    }
}
