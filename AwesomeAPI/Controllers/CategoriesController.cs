using System.Collections.Generic;
using System.Threading.Tasks;
using AwesomeAPI.Domain.Services;
using AwesomeAPI.Models;
using Microsoft.AspNetCore.Mvc;


namespace Supermarket.API.Controllers
{
    [Route("/api/[controller]")]
    public class CategoriesController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            var categories = await _categoryService.ListAsync();
            return categories;
        }
    }
}