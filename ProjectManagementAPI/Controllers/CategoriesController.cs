using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace ProjectManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : Controller
    {
        private ICategoryRepository repository = new CategoryRepository();

        // GET: api/Categories
        [HttpGet]
        public IActionResult GetCategories()
        {
            return Ok(repository.GetCategories());
        }
    }
}
