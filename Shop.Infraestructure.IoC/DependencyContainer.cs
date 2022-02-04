using System;
using Microsoft.Extensions.DependencyInjection;
using Shop.Aplication.Interfaces;
using Shop.Aplication.Services;
using Shop.Domain.Interfaces;
using Shop.Infra.Data.Repositories;

namespace Shop.Infraestructure.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Shop.Aplication
            services.AddScoped<IProductService, ProductService>();

            //Shop.Domain.Interfaces
            //Shop.Infra.Data.Repositories
            services.AddScoped<IProductRepository, ProductRepository>();
        }
    }
}
