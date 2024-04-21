namespace Airport_System.Entities
{
    public class Flight
    {
        public int Id { get; set; }
        public int FlightNumber { get; set; }
        public required Airport From { get; set; }
        public required Airport To { get; set; }
        public DateTime DepartmentTime { get; set; }
        public DateTime ArrivalTime { get; set; }
    }
}
