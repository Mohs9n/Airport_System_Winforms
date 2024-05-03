namespace Airport_System.Entities
{
    public class Flight
    {
        public required int FlightNumber { get; set; }
        public required string FromCode { get; set; }
        public required string ToCode { get; set; }
        public required Airplane Plane { get; set; }
        public DateTime DepartmentTime { get; set; }
        public DateTime ArrivalTime { get; set; }
    }
}