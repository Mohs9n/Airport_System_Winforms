namespace Airport_System.Entities
{
    [Serializable]
    public class User
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public required string PhoneNumber { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public List<Ticket> Tickets { get; set; } = [];
    }
}
