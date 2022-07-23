using DDona.JaReclamouHoje.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DDona.JaReclamouHoje.Infra.EntityConfigurations
{
    public class PessoaConfiguration : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasMany(x => x.Reclamacoes)
                .WithOne(x => x.Pessoa);
        }
    }
}
