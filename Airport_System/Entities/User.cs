namespace Airport_System.Entities
{
    public class User
    {
        int Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public byte[] Password { get; set; } = [];
    }
}
