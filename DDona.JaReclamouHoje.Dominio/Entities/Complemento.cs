using DDona.JaReclamouHoje.Dominio.Entities.Base;

namespace DDona.JaReclamouHoje.Dominio.Entities
{
    public class Complemento : EntidadeBase
    {
        public Pessoa Pessoa { get; private set; }
        public Reclamacao ReclamacaoOriginal { get; private set; }
        public string Descricao { get; set; }

        public Complemento(Pessoa pessoa, Reclamacao reclamacaoOriginal, string descricao)
        {
            Pessoa = pessoa;
            ReclamacaoOriginal = reclamacaoOriginal;
            Descricao = descricao;
        }
    }
}
