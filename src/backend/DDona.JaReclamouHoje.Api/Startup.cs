using DDona.JaReclamouHoje.Api.Extensions;
using DDona.JaReclamouHoje.Infra.ServiceCollection;

namespace DDona.JaReclamouHoje.Api
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public IWebHostEnvironment Environment { get; }

        public Startup(IConfiguration configuration, IWebHostEnvironment environment)
        {
            Configuration = configuration;
            Environment = environment;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.ConfigurarAppInsights();
            services.AdicionarControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            services.ConfigurarOptions(Configuration);
            services.AddEntityFrameworkCore(Configuration);
            services.AdicionarRepositories();
            services.AdicionarBackgroundTasks(Environment);
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
