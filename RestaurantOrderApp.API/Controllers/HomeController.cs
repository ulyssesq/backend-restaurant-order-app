using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace RestaurantOrderApp.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Service is working");
        }
    }
}
