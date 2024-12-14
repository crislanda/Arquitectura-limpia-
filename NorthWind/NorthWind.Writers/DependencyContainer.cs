using Microsoft.Extensions.DependencyInjection;
using NorthWind.Entities.Interfaces;

namespace NorthWind.Writers;

public static class DependencyContainer
{
    public static IServiceCollection AddConsoleWriter(this IServiceCollection services)
    {
        services.AddSingleton<IUserActionWriter, ConsoleWriter>();
        return services;
    }

    public static IServiceCollection AddDebugWriter(this IServiceCollection services)
    {
        services.AddSingleton<IUserActionWriter, DebugWriter>();
        return services;
    }

    public static IServiceCollection AddFileWriter(this IServiceCollection services)
    {
        services.AddSingleton<IUserActionWriter, FileWriter>();
        return services;
    }
}
