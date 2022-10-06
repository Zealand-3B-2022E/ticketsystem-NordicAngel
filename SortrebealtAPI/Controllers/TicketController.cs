using Microsoft.AspNetCore.Mvc;
using StoreBaeltTicketLibrary;
using maneger = SortrebealtAPI.Managers.TicketManeger;

namespace SortrebealtAPI.Controllers
{
    [Route("api/tickets")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(maneger.Get());
        }

        [HttpGet]
        [Route("{licensplate}")]
        public IActionResult Get(string licensplate)
        {
            try
            {
                return Ok(maneger.Get(licensplate));
            }
            catch (KeyNotFoundException)
            {

                return NotFound();
            }
        }

        [HttpPost]
        [Route("car")]
        public IActionResult CreateCar([FromBody] Car car)
        {
            maneger.Create(car);
            return Created("api/tickets" + car.Licensplate, car);
        }
    }
}
