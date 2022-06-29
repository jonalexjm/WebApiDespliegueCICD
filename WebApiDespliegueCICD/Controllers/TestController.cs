using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiDespliegueCICD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet(Name = "ObtenerEresUnGenio")]
        public IActionResult ObtenerEresUnGenio()
        {
            return Ok(new
            {
                genio = "Eres un maldito genio"
            });
        }
    }
}
