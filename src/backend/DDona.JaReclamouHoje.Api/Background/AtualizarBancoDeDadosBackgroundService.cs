using DDona.JaReclamouHoje.Infra.Contexts;
using Microsoft.EntityFrameworkCore;

namespace DDona.JaReclamouHoje.Api.Background
{
    public class AtualizarBancoDeDadosBackgroundService : BackgroundService
    {
        private readonly ILogger<AtualizarBancoDeDadosBackgroundService> _Logger;
        private readonly IServiceProvider _Services;

        public AtualizarBancoDeDadosBackgroundService(ILogger<AtualizarBancoDeDadosBackgroundService> logger,
            IServiceProvider services)
        {
            _Logger = logger;
            _Services = services;
        }

        public override Task StartAsync(CancellationToken cancellationToken)
        {
            _Logger.LogInformation("Inicio");
            return base.StartAsync(cancellationToken);
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            using(var scope = _Services.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<ReclamacoesDBContext>();
                dbContext.Database.Migrate();
            }

            return Task.CompletedTask;
        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {
            _Logger.LogInformation("Fim");
            return base.StopAsync(cancellationToken);
        }
    }
}
