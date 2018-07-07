using Microsoft.AspNetCore.Mvc;

namespace ProtoTrial.Web.Controllers
{
    [Route("")]
    [ApiController]
    public class ASMXController : ControllerBase
    {

        [HttpGet()]
        public IActionResult Action()
        {
            return Ok();
        }

        [HttpPost("something.asmx")]
        public IActionResult PostActionBasic([FromBody]string data)
        {

            return Ok();
        }

        [HttpPost("something.asmx/{methodName}")]
        public IActionResult PostAction(string methodName, [FromBody]string data)
        {

            return Ok();
        }
    }
}