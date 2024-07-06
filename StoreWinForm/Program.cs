using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Store.Domain;
using Store.Domain.Seeds;

namespace StoreWinFrom
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var builder = new HostBuilder()
                .ConfigureAppConfiguration((context, config) =>
                {
                    config.SetBasePath(Directory.GetCurrentDirectory());
                    config.AddJsonFile("appsettings.json");
                })
                .ConfigureServices((context, services) =>
                {
                    var connectionString = context.Configuration.GetConnectionString("Default");
                    services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(connectionString));

                    services.AddTransient<LoginForm>();
                });

            var host = builder.Build();

            using (var serviceScope = host.Services.CreateScope())
            {
                var services = serviceScope.ServiceProvider;
                var context = services.GetService<AppDbContext>();
                AppDbContextInitializer.Seed(context);

                ApplicationConfiguration.Initialize();
                Application.Run(services.GetService<LoginForm>());
            }
        }
    }
}