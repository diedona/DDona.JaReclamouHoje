using DDona.JaReclamouHoje.Dominio.Entities.Base;

namespace DDona.JaReclamouHoje.Dominio.Entities
{
    public class Pessoa : EntidadeBase
    {
        private readonly List<Reclamacao> _Reclamacoes = new();
        private readonly List<Complemento> _Complementos = new();

        public string Nome { get; private set; }
        public string NomeDeUsuario { get; private set; }
        public IReadOnlyCollection<Reclamacao> Reclamacoes => _Reclamacoes.AsReadOnly();
        public IReadOnlyCollection<Complemento> Complementos => _Complementos.AsReadOnly();

        public Pessoa(string nome, string nomeDeUsuario)
        {
            Nome = nome;
            NomeDeUsuario = nomeDeUsuario;
        }

        public Reclamacao CriarReclamacao(Assunto assunto, string? descricao = null)
        {
            var reclamacao = new Reclamacao(this, assunto, descricao);
            _Reclamacoes.Add(reclamacao);

            return reclamacao;
        }

        public Complemento CriarComplemento(Reclamacao reclamacao, string descricao)
        {
            var complemento = new Complemento(reclamacao, this, descricao);
            reclamacao.AdicionarComplemento(complemento);
            _Complementos.Add(complemento);

            return complemento;
        }
    }
}
