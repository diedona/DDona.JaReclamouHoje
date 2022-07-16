using DDona.JaReclamouHoje.Dominio.Entities;
using DDona.JaReclamouHoje.Dominio.Entities.Base;

namespace DDona.JaReclamouHoje.Testes.Entities
{
    public class EntidadeBaseTestes
    {
        [Fact]
        public void Entidade_Criada_Deve_Ter_Id()
        {
            EntidadeBase entidade = new Pessoa("Diego", "diego.dona");
            Assert.NotEqual(Guid.Empty, entidade.Id);
        }

        [Fact]
        public void Entidade_Criada_Deve_Ter_DataCriacao()
        {
            EntidadeBase entidade = new Pessoa("Diego", "diego.dona");
            Assert.NotEqual(DateTime.MinValue, entidade.DataCriacao);
        }
    }
}
