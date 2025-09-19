namespace FiltersInMVC.Models
{
    public class Contact
    {
        public Guid Id { get; set; } = new Guid();
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Subject { get; set; }
        public required string Message { get; set; }
    }
}
