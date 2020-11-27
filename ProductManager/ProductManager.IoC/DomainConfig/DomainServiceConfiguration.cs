using Microsoft.Extensions.DependencyInjection;
using ProductManager.Domain.Contracts.DomainServices;
using ProductManager.Domain.DomainServices;

namespace ProductManager.IoC.DomainConfig
{
    public class DomainServiceConfiguration
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IProdutoDomainService, ProdutoDomainService>();
        }
    }
}
