using PaivaStore.Domain.Entities;

namespace PaivaStore.Domain.Interfaces.Repositories;

public interface IProductRepository
{
    Task<List<Product>> GetAllProductsAsync();
}
