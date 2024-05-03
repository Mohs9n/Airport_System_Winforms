namespace Airport_System.Entities
{
    public class Ticket
    {
        public required int TicketNumber { get; set; }
        public bool Expired { get; set; } = false;
        public required int  FlightNumber { get; set; }
        public required int UserId { get; set; }
    }
}
