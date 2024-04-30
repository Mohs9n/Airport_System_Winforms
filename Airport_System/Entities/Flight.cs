namespace Airport_System.Entities
{
    public class Flight
    {
        public required int FlightNumber { get; set; }
        public required Airport From { get; set; }
        public required Airport To { get; set; }
        public required Airplane Plane { get; set; }
        public DateTime DepartmentTime { get; set; }
        public DateTime ArrivalTime { get; set; }
    }
}