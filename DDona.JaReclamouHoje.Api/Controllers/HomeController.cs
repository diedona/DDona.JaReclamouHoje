using Microsoft.AspNetCore.Mvc;

namespace DDona.JaReclamouHoje.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            return Ok("welcome home");
        }
    }
}
