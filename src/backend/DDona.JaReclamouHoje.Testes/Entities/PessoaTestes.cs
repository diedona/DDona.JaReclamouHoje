using DDona.JaReclamouHoje.Dominio.Entities;

namespace DDona.JaReclamouHoje.Testes.Entities
{
    public class PessoaTestes
    {
        private readonly Pessoa _PessoaPadrao;
        private readonly Assunto _AssuntoPadrao;

        public PessoaTestes()
        {
            _PessoaPadrao = new Pessoa("Diego", "diego.dona");
            _AssuntoPadrao = new Assunto("Frontend");
        }

        [Fact]
        public void Pessoa_Cria_Reclamacao_Ativa()
        {
            var reclamacao = _PessoaPadrao.CriarReclamacao(_AssuntoPadrao);
            Assert.True(reclamacao.Ativo);
        }

        [Fact]
        public void Pessoa_Cria_Reclamacao_Sem_Complementos()
        {
            var reclamacao = _PessoaPadrao.CriarReclamacao(_AssuntoPadrao);
            Assert.Empty(reclamacao.Complementos);
        }

        [Fact]
        public void Pessoa_Cria_Complemento_entao_Reclamacao_Tem_Complemento()
        {
            var reclamacao = _PessoaPadrao.CriarReclamacao(_AssuntoPadrao);
            var complemento = _PessoaPadrao.CriarComplemento(reclamacao, "Cada minuto eu sei menos");
            Assert.NotEmpty(reclamacao.Complementos);
        }
        
        [Fact]
        public void Pessoa_Cria_Complemento_entao_ReclamacaoOriginal_Tem_Mesmo_Id()
        {
            var reclamacao = _PessoaPadrao.CriarReclamacao(_AssuntoPadrao);
            var complemento = _PessoaPadrao.CriarComplemento(reclamacao, "Cada minuto eu sei menos");
            Assert.Equal(reclamacao.Id, complemento.ReclamacaoOriginal.Id);
        }

        [Fact]
        public void Pessoa_Cria_Complemento_entao_Pessoa_Tem_Lista_Complementos()
        {
            var reclamacao = _PessoaPadrao.CriarReclamacao(_AssuntoPadrao);
            var complemento = _PessoaPadrao.CriarComplemento(reclamacao, "Cada minuto eu sei menos");
            Assert.Equal(_PessoaPadrao.Complementos.FirstOrDefault()!.Id, complemento.Id);
        }
    }
}
