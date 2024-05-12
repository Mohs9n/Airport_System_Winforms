namespace Airport_System.Entities
{
    [Serializable]
    public class Airplane
    {
        public int Id { get; set; }
        public required string PlaneModel { get; set; }
        public required string Company { get; set; }
        public int Capacity { get; set; }
        public required int TopSpeed { get; set; }
    }
}
