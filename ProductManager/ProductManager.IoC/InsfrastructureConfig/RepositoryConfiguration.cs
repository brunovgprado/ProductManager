﻿using Microsoft.Extensions.DependencyInjection;
using ProductManager.Domain.Contracts.Repository;
using ProductManager.Infrastructure.Persistence.Repositories;

namespace ProductManager.IoC.InsfrastructureConfig
{
    public class RepositoryConfiguration
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient(typeof(IRepositoryBase<,>), typeof(RepositoryBase<,>));
            services.AddTransient<IProdutoRepository, ProdutoRepository>();
        }
    }
}
