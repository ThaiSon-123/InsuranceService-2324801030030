using Microsoft.EntityFrameworkCore;
using PricingService.Commands;
using PricingService.Controllers;
using PricingService.Data;
using PricingService.Domain;

namespace PricingService;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDbContext<PricingDbContext>(options =>
            options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection")));
        services.AddScoped<ITariffRepository, TariffRepository>();
        services.AddScoped<IDataStore, DataStore>();

        services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<CalculatePriceHandler>());

        // The answer DTOs are polymorphic and use a Newtonsoft JsonConverter.
        services.AddControllers(options => options.Filters.Add<ErrorFilter>())
            .AddNewtonsoftJson();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        using (var scope = app.ApplicationServices.CreateScope())
        {
            DatabaseInitializer.Initialize(scope.ServiceProvider.GetRequiredService<PricingDbContext>());
        }

        app.UseRouting();
        app.UseEndpoints(endpoints => endpoints.MapControllers());
    }
}
