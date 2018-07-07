using Microsoft.AspNetCore.Mvc;
using ProtoTrial.Dto;

namespace ProtoTrial.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SatelliteController : ControllerBase
    {
        [HttpPost()]
        public IActionResult AddSatellite([FromBody]Satellite satellite)
        {
            return Ok(satellite);
        }
    }
}

