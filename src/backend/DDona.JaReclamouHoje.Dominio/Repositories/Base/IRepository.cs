using DDona.JaReclamouHoje.Dominio.Entities.Base;

namespace DDona.JaReclamouHoje.Dominio.Repositories.Base
{
    public interface IRepository<T> where T : EntidadeBase
    {
        Task<IEnumerable<T>> ObterTodos();
        Task<T?> ObterPorId (Guid id);
    }
}
