using DDona.JaReclamouHoje.Dominio.Entities.Base;

namespace DDona.JaReclamouHoje.Dominio.Entities
{
    public class Complemento : EntidadeBase
    {
        public Reclamacao ReclamacaoOriginal { get; private set; }
        public Pessoa PessoaQueComplementou { get; private set; }
        public string Descricao { get; private set; }

        private Complemento() { }

        public Complemento(Reclamacao reclamacao, Pessoa pessoaQueComplementou, string descricao)
        {
            ReclamacaoOriginal = reclamacao;
            Descricao = descricao;
            PessoaQueComplementou = pessoaQueComplementou;
        }
    }
}
