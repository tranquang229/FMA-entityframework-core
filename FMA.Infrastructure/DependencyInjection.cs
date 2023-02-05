using FMA.Infrastructure.Identity;
using FMA.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FMA.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("AppDatabase"),
                b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName))
        );

        services.AddDbContext<ApplicationDbContext>();
        services.AddIdentity<ApplicationUser, ApplicationRole>(
                options =>
                {
                    options.SignIn.RequireConfirmedAccount = false;
                }
            )
            .AddEntityFrameworkStores<ApplicationDbContext>();

        services.AddScoped<ApplicationDbContextInitialiser>();

        return services;
    }
}