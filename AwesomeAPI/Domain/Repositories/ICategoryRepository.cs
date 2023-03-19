using AwesomeAPI.Models;

namespace AwesomeAPI.Domain.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> ListAsync();


    }
}
