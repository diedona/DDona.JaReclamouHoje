using DDona.JaReclamouHoje.Api.Models.AppSettings;

namespace DDona.JaReclamouHoje.Api.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void ConfigurarOptions(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<MockSettingsOptions>(configuration.GetSection(MockSettingsOptions.Postion));
        }
    }
}
