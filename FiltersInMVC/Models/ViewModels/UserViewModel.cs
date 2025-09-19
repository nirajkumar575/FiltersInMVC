namespace FiltersInMVC.Models.ViewModels
{
    public class UserViewModel
    {
        public required string Username { get; set; }
        public required string Password { get; set; }
        public string ? Email { get; set; }
        public string ? Phone { get; set; }
        public bool RememberMe { get; set; }
    }
}
