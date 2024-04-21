namespace Airport_System.Entities
{
    public class Airport
    {
        public int Id { get; set; }
        public required string AirportCode { get; set; }
        public required string Name { get; set; }
        public required Country Country { get; set; }
        public required City City { get; set; }
        public List<Airplane> Airplane { get; set; } = [];
        public List<Flight> Flights { get; set; } = [];
        public List<User> Users { get; set; } = [];
    }
}
