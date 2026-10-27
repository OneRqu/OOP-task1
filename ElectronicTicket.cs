namespace OOP_task1
{
    public class ElectronicTicket : Ticket
    {
        public string QrCodeText;
        public string BuyerEmail;

        public ElectronicTicket(int id, Session session, Seat seat, string qr, string email) : base(id, session, seat)
        {
            QrCodeText = qr;
            BuyerEmail = email;
        }
    }
}
