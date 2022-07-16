using DDona.JaReclamouHoje.Infra.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace DDona.JaReclamouHoje.Infra.Contexts
{
    public class ReclamacoesDBContext : DbContext
    {
        public ReclamacoesDBContext() : base() { }
        public ReclamacoesDBContext(DbContextOptions<ReclamacoesDBContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ConfigurationsAssembly).Assembly);
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);
            configurationBuilder.Properties<string>()
                .AreUnicode()
                .HaveMaxLength(1000);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
