using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PaivaStore.Domain.Interfaces.Repositories;
using PaivaStore.Infra.Data;
using PaivaStore.Infra.Repositories;

namespace PaivaStore.Infra;

public static class ServiceCollectionExtensions
{
    public static void AddInfraDependency(this IServiceCollection services)
    {
        services.AddDbContext<PaivaStoreDbContext>(options => options.UseSqlite("Data Source=PaivaStoreDb.db"));
        services.AddScoped<IProductRepository, ProductRepository>();
    }
}