using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CatalogService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private static readonly string[] products = ["Product1", "Product2","Product3"];
        private static readonly string[] secureProds = [ "SuperProduct1", "TopSecretProduct2" ];

        [HttpGet]
        public IActionResult Get() => Ok(products);
        [HttpGet("secure")]
        [Authorize] // <---- Requires JWT!
        public IActionResult GetSecretProducts()
        {
            return Ok(secureProds);
        }
    }

}
