using FiltersInMVC.Models;

namespace FiltersInMVC.Data.Repository
{
    public interface IContactRepository
    {
        Task<bool> CreateAsync(Contact contact);
    }
}
