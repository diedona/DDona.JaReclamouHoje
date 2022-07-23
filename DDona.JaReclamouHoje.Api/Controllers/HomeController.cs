using DDona.JaReclamouHoje.Api.Models.AppSettings;
using DDona.JaReclamouHoje.Dominio.Entities;
using DDona.JaReclamouHoje.Infra.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace DDona.JaReclamouHoje.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly MockSettingsOptions _MockSettingsOptions;
        private readonly ReclamacoesDBContext _Context;

        public HomeController(IOptions<MockSettingsOptions> mockSettingsOptions, ReclamacoesDBContext context)
        {
            _MockSettingsOptions = mockSettingsOptions.Value;
            _Context = context;
        }

        [HttpGet]
        public ActionResult Get()
        {
            List<Pessoa> data = _Context.Set<Pessoa>().Include(x => x.Reclamacoes).ToList();
            return Ok(data);
        }
    }
}
