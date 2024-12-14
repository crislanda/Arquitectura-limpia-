using Microsoft.Extensions.DependencyInjection;
using NorthWind.Core;
using NorthWind.Writers;

namespace NorthWind.IoC;

public static class DependencyContainer
{
    public static IServiceCollection AddNorthWindServices(this IServiceCollection services)
    {
        services.AddDebugWriter();
        services.AddServices();
        return services;
    }

}
