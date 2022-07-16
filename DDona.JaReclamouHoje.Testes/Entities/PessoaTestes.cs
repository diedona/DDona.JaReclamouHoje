using DDona.JaReclamouHoje.Dominio.Entities;

namespace DDona.JaReclamouHoje.Testes.Entities
{
    public class PessoaTestes
    {
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
