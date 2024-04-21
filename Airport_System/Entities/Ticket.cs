namespace Airport_System.Entities
{
    public class Ticket
    {
        public int Id { get; set; }
        public required string Type { get; set; }
        public required int TicketNumber { get; set; }
        public bool Expired { get; set; } = false;
        public required Flight Flight { get; set; }
        public required User User { get; set; }
    }
}
