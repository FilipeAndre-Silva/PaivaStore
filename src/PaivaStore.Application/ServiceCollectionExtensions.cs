using Microsoft.Extensions.DependencyInjection;
using PaivaStore.Infra;
using PaivaStore.Domain;
using PaivaStore.Application.Services;
using PaivaStore.Application.Interfaces;

namespace PaivaStore.Application;

public static class ServiceCollectionExtensions
{
    public static void AddApplicationService(this IServiceCollection services)
    {
        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        services.AddInfraDependency();
        services.AddDomainServiceDependency();

        services.AddScoped<IProductApplicationService, ProductApplicationService>();
    }
}