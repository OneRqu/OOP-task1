namespace OOP_task1
{
    public class Ticket
    {
        private Session _session;
        public int Id { get; }
        public int RowNumber { get; }
        public int SeatNumber { get; }

        public Ticket(int id, Session session, Seat seat)
        {
            Id = id;
            _session = session;
            RowNumber = seat.Row;
            SeatNumber = seat.Number;
        }
    }
}
