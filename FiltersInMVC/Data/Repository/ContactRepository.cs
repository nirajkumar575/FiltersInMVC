using FiltersInMVC.Models;
using Microsoft.AspNetCore.Http.HttpResults;

namespace FiltersInMVC.Data.Repository
{
    public class ContactRepository : IContactRepository
    {
        private readonly ApplicationDbContext _context;
        public ContactRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<bool> CreateAsync(Contact contact)
        {
            await _context.Contacts.AddAsync(contact);
            int result = await _context.SaveChangesAsync();
            return result>0;
        }
    }
}
