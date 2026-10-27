namespace OOP_task1;

class Program
{
    public static void Main()
    {
        Cinema cinema = new Cinema("Мягкий кинотеатр", "г. Челябинск, ул. Молдавская, 16, ТРК \"Фокус\", 3 этаж");
        
        Hall hall1 = new Hall(1);
        Hall hall2 = new Hall(2);

        cinema.AddHall(hall1);
        cinema.AddHall(hall2);

        Seat seat1 = new Seat(8, 5);
        Seat seat2 = new Seat(1, 3);
        Seat seat3 = new Seat(12, 7);

        hall1.AddSeat(seat1);
        hall1.AddSeat(seat2);
        hall2.AddSeat(seat3);

        Movie movie1 = new Movie("Гарри Поттер и философский камень", 152);

        cinema.AddMovie(movie1);

        Session session1 = new Session("2026-10-26 15:00", movie1, 110.00);

        Ticket ticket1 = new Ticket(61346, session1, seat1);

        ElectronicTicket ticket2 = new ElectronicTicket(
            61347,
            session1,
            seat2,
            "cinema.ru",
            "example@mail.com"
        );

        session1.AddTicket(ticket1);
        session1.AddTicket(ticket2);
    }
}
