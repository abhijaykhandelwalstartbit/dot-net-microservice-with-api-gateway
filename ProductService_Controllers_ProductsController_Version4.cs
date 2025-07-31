using Microsoft.AspNetCore.Mvc;

namespace ProductService.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() =>
            Ok(new[] { new { Id = 1, Name = "Laptop" }, new { Id = 2, Name = "Phone" } });
    }
}