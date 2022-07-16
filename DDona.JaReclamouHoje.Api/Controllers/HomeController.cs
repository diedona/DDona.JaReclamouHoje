using DDona.JaReclamouHoje.Api.Models.AppSettings;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace DDona.JaReclamouHoje.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly MockSettingsOptions _MockSettingsOptions;

        public HomeController(IOptions<MockSettingsOptions> mockSettingsOptions)
        {
            _MockSettingsOptions = mockSettingsOptions.Value;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok($"welcome home - {_MockSettingsOptions.Data}");
        }
    }
}
