using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using ProductManager.Api.Configurations;
using ProductManager.Api.Contracts;
using ProductManager.Api.Models;
using ProductManager.IoC.ApplicationConfig;
using ProductManager.IoC.DomainConfig;
using ProductManager.IoC.InsfrastructureConfig;

namespace ProductManager.Api
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();
            services.AddControllers();
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IActionResultConverter, ActionResultConverter>();
            services.ConfigureSwagger();

            RepositoryConfiguration.ConfigureServices(services);
            DomainServiceConfiguration.ConfigureServices(services);
            ValidatorsConfiguration.ConfigureServices(services);
            AppServicesConfiguration.ConfigureServices(services);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwaggerExtensions();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
