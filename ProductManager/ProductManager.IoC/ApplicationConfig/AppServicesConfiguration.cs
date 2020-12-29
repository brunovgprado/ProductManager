using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using ProductManager.Application.AppServices;
using ProductManager.Application.Contracts;
using System;

namespace ProductManager.IoC.ApplicationConfig
{
    public static class AppServicesConfiguration
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IProdutoAppService, ProdutoAppService>();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }
    }
}
