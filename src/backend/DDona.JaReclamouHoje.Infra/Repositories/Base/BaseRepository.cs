using DDona.JaReclamouHoje.Dominio.Entities.Base;
using DDona.JaReclamouHoje.Dominio.Repositories.Base;
using DDona.JaReclamouHoje.Infra.Contexts;
using Microsoft.EntityFrameworkCore;

namespace DDona.JaReclamouHoje.Infra.Repositories.Base
{
    public abstract class BaseRepository<T> : IRepository<T> where T : EntidadeBase
    {
        private readonly ReclamacoesDBContext _Context;
        private readonly DbSet<T> _DbSet;

        public BaseRepository(ReclamacoesDBContext context)
        {
            _Context = context;
            _DbSet = _Context.Set<T>();
        }

        public async Task<T?> ObterPorId(Guid id)
        {
            return await _DbSet.FirstOrDefaultAsync(x => x.Id.Equals(id));
        }

        public async Task<IEnumerable<T>> ObterTodos()
        {
            return await _DbSet.ToListAsync();
        }
    }
}
