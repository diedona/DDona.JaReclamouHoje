using DDona.JaReclamouHoje.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DDona.JaReclamouHoje.Infra.EntityConfigurations
{
    public class ComplementoConfiguration : IEntityTypeConfiguration<Complemento>
    {
        public void Configure(EntityTypeBuilder<Complemento> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Descricao);

            builder.HasOne(x => x.ReclamacaoOriginal)
                .WithMany(x => x.Complementos)
                .HasForeignKey(x => x.ReclamacaoOriginalId);

            builder.HasOne(x => x.PessoaQueComplementou)
                .WithMany(pessoa => pessoa.Complementos)
                .HasForeignKey(x => x.PessoaQueComplementouId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
