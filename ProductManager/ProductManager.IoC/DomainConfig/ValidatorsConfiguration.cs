using Microsoft.Extensions.DependencyInjection;
using ProductManager.Domain.Validators.ProductValidator;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManager.IoC.DomainConfig
{
    public class ValidatorsConfiguration
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<CreateProductValidator, CreateProductValidator>();
        }
    }
}
