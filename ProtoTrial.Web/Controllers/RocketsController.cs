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
    }
}