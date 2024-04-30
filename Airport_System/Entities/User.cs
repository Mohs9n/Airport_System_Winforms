namespace Airport_System.Entities
{
    public class User
    {
        int Id { get; set; }
        public required string Name { get; set; }
        public required string PhoneNumber { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
    }
}
