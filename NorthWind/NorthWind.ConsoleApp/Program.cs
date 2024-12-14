using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using NorthWind.ConsoleApp.Services;
using NorthWind.Entities.Interfaces;
using NorthWind.Writers;
using NorthWind.IoC;

namespace NorthWind.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HostApplicationBuilder Builder = Host.CreateApplicationBuilder();

            Builder.Services.AddNorthWindServices();

            

            using var AppHost = Builder.Build();

            IAppLogger Logger = AppHost.Services.GetRequiredService<IAppLogger>();
            Logger.WriteLog("Application started!!");

            IProductService Service = AppHost.Services.GetRequiredService<IProductService>();
            Service.Add("Emmanuel", "Azucar");

            /*
             * AppLogger y los writers : REsponsabilidad única
             * Apploger: Abierto pero cerrado
             * AppLogger: Inversión de dependencias. Los modulos
             * de alto nivel son independientes de los detalles de implementación
             */
        }
    }
}
