using Microsoft.Extensions.DependencyInjection;
using ProductManager.Application.AppServices;
using ProductManager.Application.Contracts;

namespace ProductManager.IoC.ApplicationConfig
{
    public class AppServicesConfigurations
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IProdutoAppService, ProdutoAppService>();
        }
    }
}
