using Microsoft.Extensions.DependencyInjection;
using ProductManager.Domain.Validators.ProductValidator;

namespace ProductManager.IoC.DomainConfig
{
    public class ValidatorsConfiguration
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<CreateProductValidator, CreateProductValidator>();
            services.AddSingleton<UpdateProductValidator, UpdateProductValidator>();
        }
    }
}
