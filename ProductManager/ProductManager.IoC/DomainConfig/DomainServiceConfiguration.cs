using Microsoft.Extensions.DependencyInjection;
using ProductManager.Domain.Contracts.DomainServices;
using ProductManager.Domain.DomainServices;
using ProductManager.Domain.Validators.ProductValidator;

namespace ProductManager.IoC.DomainConfig
{
    public static class DomainServiceConfiguration
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IProdutoDomainService, ProdutoDomainService>();
            services.AddSingleton<CreateProductValidator, CreateProductValidator>();
        }
    }
}
