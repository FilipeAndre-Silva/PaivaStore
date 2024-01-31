using Microsoft.Extensions.DependencyInjection;
using PaivaStore.Domain.Interfaces;
using PaivaStore.Domain.Services;

namespace PaivaStore.Domain;

public static class ServiceCollectionExtensions
{
    public static void AddDomainServiceDependency(this IServiceCollection services)
    {
        services.AddScoped<IProductService, ProductService>();
    }
}