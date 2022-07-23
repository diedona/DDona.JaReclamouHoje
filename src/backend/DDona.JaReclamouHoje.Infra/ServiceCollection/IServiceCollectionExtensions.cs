using DDona.JaReclamouHoje.Dominio.Repositories;
using DDona.JaReclamouHoje.Infra.Contexts;
using DDona.JaReclamouHoje.Infra.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DDona.JaReclamouHoje.Infra.ServiceCollection
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddEntityFrameworkCore(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ReclamacoesDBContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            return services;
        }

        public static IServiceCollection AdicionarRepositories(this IServiceCollection services)
        {
            services.AddScoped<IPessoaRepository, PessoaRepository>();

            return services;
        }
    }
}
