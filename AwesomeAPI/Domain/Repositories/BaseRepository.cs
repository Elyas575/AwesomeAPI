
using AwesomeAPI.Persistence.Contexts;

namespace AwesomeAPI.Domain.Repositories
{

    public abstract class BaseRepository
    {
        protected readonly AppDbContext _context;

        public BaseRepository(AppDbContext context)
        {
            _context = context;
        }
    }
}
  
