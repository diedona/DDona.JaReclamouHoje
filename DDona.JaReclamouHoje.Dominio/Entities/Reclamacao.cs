using DDona.JaReclamouHoje.Dominio.Entities.Base;
using System.Collections.ObjectModel;

namespace DDona.JaReclamouHoje.Dominio.Entities
{
    public class Reclamacao : EntidadeBase
    {
        private readonly List<Complemento> _Complementos = new();

        public Pessoa Pessoa { get; private set; }
        public Assunto Assunto { get; private set; }
        public string? Descricao { get; private set; }
        public bool Ativo { get; private set; }
        public ReadOnlyCollection<Complemento> Complementos => _Complementos.AsReadOnly();

        public Reclamacao(Pessoa pessoa, Assunto assunto, string? descricao)
        {
            Pessoa = pessoa;
            Assunto = assunto;
            Descricao = descricao;
            Ativo = true;
        }

        public void AdicionarComplemento(Complemento complemento)
        {
            _Complementos.Add(complemento);
        }
    }
}
