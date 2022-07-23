using DDona.JaReclamouHoje.Dominio.Entities.Base;

namespace DDona.JaReclamouHoje.Dominio.Entities
{
    public class Reclamacao : EntidadeBase
    {
        private readonly List<Complemento> _Complementos = new();

        public Pessoa Pessoa { get; private set; }
        public Guid PessoaId { get; private set; }
        public Assunto Assunto { get; private set; }
        public Guid AssuntoId { get; private set; }
        public string? Descricao { get; private set; }
        public bool Ativo { get; private set; }
        public IReadOnlyCollection<Complemento> Complementos => _Complementos.AsReadOnly();

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        private Reclamacao() { }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

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
