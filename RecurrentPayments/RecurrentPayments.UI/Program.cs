using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RecurrentPayments.Application.Services;
using RecurrentPayments.Infrastructure.Persistence;
using Application = System.Windows.Forms.Application;

namespace RecurrentPayments.UI;

static class Program
{
    public static ServiceProvider ServiceProvider { get; private set; } = null!;

    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        var services = new ServiceCollection();
        ConfigureServices(services);
        ServiceProvider = services.BuildServiceProvider();

        // Inicializar BD
        using var scope = ServiceProvider.CreateScope();
        var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
        DatabaseInitializer.Initialize(db);

        System.Windows.Forms.Application.Run(new MainForm());

    }

    static void ConfigureServices(IServiceCollection services)
    {
        var dbPath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "RecurrentPayments",
            "app.db"
        );

        Directory.CreateDirectory(Path.GetDirectoryName(dbPath)!);

        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlite($"Data Source={dbPath}"));
        // Servicios
        services.AddScoped<ClientService>();
        services.AddScoped<ContractService>();
    }
}