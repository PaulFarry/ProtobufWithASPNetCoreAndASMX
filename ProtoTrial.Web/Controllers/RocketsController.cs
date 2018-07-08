using Microsoft.AspNetCore.Mvc;
using ProtoTrial.Dto;

namespace ProtoTrial.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RocketsController : ControllerBase
    {

        [HttpPost()]
        public IActionResult CreateRocket([FromBody]Rocket rocket)
        {
            return Ok(rocket);
        }

        [HttpGet("{value}/{diameter}")]
        public IActionResult GetRocket(int value, int diameter)
        {
            var rocket = new Rocket { Value = value, Diameter = diameter };
            return Ok(rocket);
        }
    }
}