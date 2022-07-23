using DDona.JaReclamouHoje.Dominio.Entities.Base;

namespace DDona.JaReclamouHoje.Dominio.Entities
{
    public class Assunto : EntidadeBase
    {
        private readonly List<Reclamacao> _Reclamacoes = new();

        public string Descricao { get; private set; }
        public IReadOnlyCollection<Reclamacao> Reclamacoes => _Reclamacoes.AsReadOnly();

        public Assunto(string descricao)
        {
            Descricao = descricao;
        }
    }
}
