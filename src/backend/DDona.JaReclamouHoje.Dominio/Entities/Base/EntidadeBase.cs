namespace DDona.JaReclamouHoje.Dominio.Entities.Base
{
    public abstract class EntidadeBase
    {
        public Guid Id { get; private set; }
        public DateTime DataCriacao { get; private set; }
        public DateTime? DataAlteracao { get; private set; }

        protected EntidadeBase()
        {
            Id = Guid.NewGuid();
            DataCriacao = DateTime.UtcNow;
            DataAlteracao = null;
        }
    }
}
