using FiltersInMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace FiltersInMVC.Data.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;
        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<User?> GetUserAsync(string username,string password)
        {
            return await _context.User
                .FirstOrDefaultAsync(u => u.Username == username && u.Password==password);
        }

    }
}
