using DDona.JaReclamouHoje.Dominio.Entities.Base;

namespace DDona.JaReclamouHoje.Dominio.Entities
{
    public class Assunto : EntidadeBase
    {
        public string Descricao { get; set; }

        public Assunto(string descricao)
        {
            Descricao = descricao;
        }
    }
}
