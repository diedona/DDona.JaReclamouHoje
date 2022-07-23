using DDona.JaReclamouHoje.Api.Models.AppSettings;
using System.Text.Json.Serialization;

namespace DDona.JaReclamouHoje.Api.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection ConfigurarOptions(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<MockSettingsOptions>(configuration.GetSection(MockSettingsOptions.Postion));
            return services;
        }

        public static IServiceCollection AdicionarControllers(this IServiceCollection services)
        {
            services.AddControllers().AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
            return services;
        }
    }
}
