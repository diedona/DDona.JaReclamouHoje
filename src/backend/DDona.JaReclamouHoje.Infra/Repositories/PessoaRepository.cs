using DDona.JaReclamouHoje.Dominio.Entities;
using DDona.JaReclamouHoje.Dominio.Repositories;
using DDona.JaReclamouHoje.Infra.Contexts;
using DDona.JaReclamouHoje.Infra.Repositories.Base;

namespace DDona.JaReclamouHoje.Infra.Repositories
{
    public class PessoaRepository : BaseRepository<Pessoa>, IPessoaRepository
    {
        public PessoaRepository(ReclamacoesDBContext context) : base(context)
        {
        }
    }
}
