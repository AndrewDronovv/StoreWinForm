using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Store.Domain;
using Store.Domain.Seeds;
using StoreWinForm.Forms;
using StoreWinFrom.Forms;

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
                    services.AddTransient<MainForm>();
                    services.AddTransient<RegisterForm>();
                    services.AddTransient<EmployeeForm>();
                    services.AddTransient<CatalogForm>();
                    services.AddTransient<ProductForm>();
                    services.AddTransient<ProfileForm>();
                    services.AddTransient<CartForm>();
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