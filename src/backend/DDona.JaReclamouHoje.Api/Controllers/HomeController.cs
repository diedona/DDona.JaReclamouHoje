using DDona.JaReclamouHoje.Api.Models.AppSettings;
using DDona.JaReclamouHoje.Dominio.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace DDona.JaReclamouHoje.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly MockSettingsOptions _MockSettingsOptions;
        private readonly IPessoaRepository _PessoaRepository;

        public HomeController(IOptions<MockSettingsOptions> mockSettingsOptions, IPessoaRepository pessoaRepository)
        {
            _MockSettingsOptions = mockSettingsOptions.Value;
            _PessoaRepository = pessoaRepository;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var pessoas = await _PessoaRepository.ObterTodos();
            return Ok(pessoas);
        }
    }
}
