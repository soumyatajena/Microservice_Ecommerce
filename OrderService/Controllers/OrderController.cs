using Microsoft.AspNetCore.Mvc;

namespace OrderService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController(IHttpClientFactory httpClientFactory) : ControllerBase
    {
        private readonly IHttpClientFactory _httpClientFactory = httpClientFactory;

        [HttpGet]
        public async Task<IActionResult> GetProductsFromCatalog()
        {
            var client = _httpClientFactory.CreateClient();
            // Change the URL/port to your actual CatalogService running address
            var result = await client.GetStringAsync("https://localhost:7190/Product");
            return Ok(new { msg = "Order Service", products = result });
        }
    }
}
