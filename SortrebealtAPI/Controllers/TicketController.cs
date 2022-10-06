using Microsoft.AspNetCore.Mvc;
using StoreBaeltTicketLibrary;
using TicketSystemClassLibrary;
using Car = StoreBaeltTicketLibrary.Car;
using maneger = SortrebealtAPI.Managers.TicketManeger;

namespace SortrebealtAPI.Controllers
{
    [Route("api/tickets")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            return Ok(maneger.Get());
        }

        [HttpGet]
        [Route("{licensplate}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
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
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult CreateCar([FromBody] Car car)
        {
            maneger.Create(car);
            return Created("api/tickets" + car.Licensplate, car);
        }

        [HttpPost]
        [Route("mc")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult CreateCar([FromBody] MC mc)
        {
            maneger.Create(mc);
            return Created("api/tickets" + mc.Licensplate, mc);
        }
    }
}
