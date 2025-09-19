namespace FiltersInMVC.Models
{
    public class User
    {
        public Guid Id { get; set; } = new Guid();
        public required string Username { get; set; }
        public required string Password { get; set; }
        public required string Email { get; set; }
        public required string Phone { get; set; }
        public bool RememberMe { get; set; }

    }
}
