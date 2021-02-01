using Microsoft.AspNetCore.Mvc;
using RestaurantOrderApp.Domain.Interfaces.Services;

namespace RestaurantOrderApp.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        
        [HttpGet("{input}")]
        public IActionResult Get(string input)
        {
            return Ok(_orderService.Get(input));
        }
    }
}