namespace Airport_System.Entities
{
    [Serializable]
    public class Airport
    {
        public required string AirportCode { get; set; }
        public required string Name { get; set; }
        public required Country Country { get; set; }
        public required City City { get; set; }
        public List<Airplane> Airplanes { get; set; } = [];
        public List<Flight> Flights { get; set; } = [];
        public required Adminstrator Adminstrator { get; set; }
        public List<User> Users { get; set; } = [];
    }
}
