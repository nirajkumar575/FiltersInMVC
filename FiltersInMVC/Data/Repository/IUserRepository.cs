using FiltersInMVC.Models;

namespace FiltersInMVC.Data.Repository
{
    public interface IUserRepository
    {
        Task<User?> GetUserAsync(string username,string password);
    }
}
