using Microsoft.AspNetCore.Mvc;
using Ordering.Domain;

namespace Ordering.API.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        // GET: api/<OrdersController>
        [HttpGet]
        public IEnumerable<Order> Get()
        {
            var orders = new List<Order>
            {
                new Order(),
                new Order(),
                new Order()
            };

            return orders;
        }
    }
}
