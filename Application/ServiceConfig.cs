using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class ServiceConfig
{
    public static IServiceCollection RegisterApplicationServices(this IServiceCollection services)
    {
        services.AddMediatR(cfg =>
            cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly())
        );

        return services;
    }
}