using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using pfp_c.Services;
using System.Windows.Forms.Design;

namespace pfp_c
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // ?? Cria configuração (lê appsettings.json)
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            // ?? Configura Injeção de Dependência
            var services = new ServiceCollection();
            services.AddSingleton<IConfiguration>(config);
            services.AddHttpClient<FuncionarioService>();

            var serviceProvider = services.BuildServiceProvider();

            ApplicationConfiguration.Initialize();

            // Exemplo de como passar o service pro form principal
            var funcionarioService = serviceProvider.GetRequiredService<FuncionarioService>();
            Application.Run(new Form1(funcionarioService));
        }
    }
}
