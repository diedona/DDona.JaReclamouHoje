using DDona.JaReclamouHoje.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DDona.JaReclamouHoje.Infra.EntityConfigurations
{
    public class ReclamacaoConfiguration : IEntityTypeConfiguration<Reclamacao>
    {
        public void Configure(EntityTypeBuilder<Reclamacao> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Pessoa)
                .WithMany(p => p.Reclamacoes);
        }
    }
}
