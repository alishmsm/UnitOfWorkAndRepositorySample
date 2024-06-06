using System.Data;
using Domain.Repository;
using Infrastructure.Context;
using Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
namespace Infrastructure;

public static class SeviceConfig
{

    public static IServiceCollection RegistrationPersistenceServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>((options)=>
            options.UseSqlServer(configuration.GetConnectionString("AppDbContext"))
            );

        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IOrderRepository, OrderRepository>();
        return services;
    }
    
    // op => op.UseSqlServer(Co.GetConnectionString("AppDbContext"))
}