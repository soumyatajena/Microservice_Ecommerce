using Microsoft.AspNetCore.Mvc;

namespace CatalogService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private static readonly string[] products = new[] { "Product1", "Product2","Product3" };

        [HttpGet]
        public IActionResult Get() => Ok(products);
    }

}
