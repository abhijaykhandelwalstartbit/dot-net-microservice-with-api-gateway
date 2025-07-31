using Microsoft.AspNetCore.Mvc;

namespace OrderService.Controllers
{
    [ApiController]
    [Route("api/orders")]
    public class OrdersController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() =>
            Ok(new[] { new { Id = 1, Product = "Laptop" }, new { Id = 2, Product = "Phone" } });
    }
}