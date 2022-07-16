using DDona.JaReclamouHoje.Dominio.Entities.Base;

namespace DDona.JaReclamouHoje.Dominio.Entities
{
    public class Pessoa : EntidadeBase
    {
        public string Nome { get; private set; }
        public string NomeDeUsuario { get; private set; }

        public Pessoa(string nome, string nomeDeUsuario)
        {
            Nome = nome;
            NomeDeUsuario = nomeDeUsuario;
        }

        public Reclamacao CriarReclamacao(Assunto assunto, string? descricao = null)
        {
            return new Reclamacao(this, assunto, descricao);
        }

        public Complemento CriarComplemento(Reclamacao reclamacao, string descricao)
        {
            var complemento = new Complemento(this, reclamacao, descricao);
            reclamacao.AdicionarComplemento(complemento);

            return complemento;
        }
    }
}
