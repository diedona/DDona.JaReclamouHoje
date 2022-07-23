using DDona.JaReclamouHoje.Api.Extensions;
using DDona.JaReclamouHoje.Infra.ServiceCollection;

namespace DDona.JaReclamouHoje.Api
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AdicionarControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            services.ConfigurarOptions(Configuration);
            services.AddEntityFrameworkCore(Configuration);
            services.AdicionarRepositories();
        }

        public void Configure(WebApplication app, IWebHostEnvironment environment)
        {
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();
        }
    }
}
