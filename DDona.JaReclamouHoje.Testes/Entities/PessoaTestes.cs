using DDona.JaReclamouHoje.Dominio.Entities;

namespace DDona.JaReclamouHoje.Testes.Entities
{
    public class PessoaTestes
    {
        [Fact]
        public void Pessoa_Criada_Deve_Ter_Id()
        {
            var pessoa = new Pessoa("Diego", "diego.dona");
            Assert.NotEqual(Guid.Empty, pessoa.Id);
        }

        [Fact]
        public void Pessoa_Criada_Deve_Ter_DataCriacao()
        {
            var pessoa = new Pessoa("Diego", "diego.dona");
            Assert.NotEqual(DateTime.MinValue, pessoa.DataCriacao);
        }

        [Fact]
        public void Pessoa_Cria_Reclamacao_Ativa()
        {
            var pessoa = new Pessoa("Diego", "diego.dona");
            var assunto = new Assunto("Frontend");
            var reclamacao = pessoa.CriarReclamacao(assunto);

            Assert.True(reclamacao.Ativo);
        }
    }
}
