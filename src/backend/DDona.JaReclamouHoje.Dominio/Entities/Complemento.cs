using DDona.JaReclamouHoje.Dominio.Entities.Base;

namespace DDona.JaReclamouHoje.Dominio.Entities
{
    public class Complemento : EntidadeBase
    {
        public Reclamacao ReclamacaoOriginal { get; private set; }
        public int ReclamacaoOriginalId { get; private set; }
        public Pessoa PessoaQueComplementou { get; private set; }
        public int PessoaQueComplementouId { get; private set; }
        public string Descricao { get; private set; }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        private Complemento() { }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        public Complemento(Reclamacao reclamacaoOriginal, Pessoa pessoaQueComplementou, string descricao)
        {
            ReclamacaoOriginal = reclamacaoOriginal;
            Descricao = descricao;
            PessoaQueComplementou = pessoaQueComplementou;
        }
    }
}
