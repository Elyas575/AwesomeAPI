using AwesomeAPI.Models;
using AwesomeAPI.Persistence.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AwesomeAPI.Domain.Repositories
{
    public class CategoryRepository : BaseRepository, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Category>> ListAsync()
        {
            var objCategoryList = await _context.Categories.ToListAsync();
            return objCategoryList;
        }
    }
}
