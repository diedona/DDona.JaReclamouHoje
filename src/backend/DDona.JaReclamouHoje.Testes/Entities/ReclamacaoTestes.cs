using DDona.JaReclamouHoje.Dominio.Entities;

namespace DDona.JaReclamouHoje.Testes.Entities
{
    public class ReclamacaoTestes
    {
        [Fact]
        public void Deve_Adicionar_Complemento()
        {
            var pessoa = new Pessoa("Diego Doná", "diego.dona");
            var outraPessoa = new Pessoa("Pedro Pedrinho", "pedro.pedrinho");
            var assunto = new Assunto("Frontend");
            var reclamacao = pessoa.CriarReclamacao(assunto, "Não gosto");
            var complemento = outraPessoa.CriarComplemento(reclamacao, "Nem eu!");

            Assert.Equal(1, reclamacao.Complementos.Count);
        }
    }
}
