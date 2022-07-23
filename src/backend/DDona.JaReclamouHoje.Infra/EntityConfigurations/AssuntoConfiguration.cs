using DDona.JaReclamouHoje.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DDona.JaReclamouHoje.Infra.EntityConfigurations
{
    public class AssuntoConfiguration : IEntityTypeConfiguration<Assunto>
    {
        public void Configure(EntityTypeBuilder<Assunto> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasMany(assunto => assunto.Reclamacoes)
                .WithOne(reclamacao => reclamacao.Assunto);
        }
    }
}
