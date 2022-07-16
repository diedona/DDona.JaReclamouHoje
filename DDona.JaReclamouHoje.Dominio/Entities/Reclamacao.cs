using DDona.JaReclamouHoje.Dominio.Entities.Base;

namespace DDona.JaReclamouHoje.Dominio.Entities
{
    public class Reclamacao : EntidadeBase
    {
        public Pessoa Pessoa { get; private set; }
        public Assunto Assunto { get; private set; }
        public string? Descricao { get; private set; }
        public bool Ativo { get; private set; }

        public Reclamacao(Pessoa pessoa, Assunto assunto, string? descricao)
        {
            Pessoa = pessoa;
            Assunto = assunto;
            Descricao = descricao;
            Ativo = true;
        }
    }
}
