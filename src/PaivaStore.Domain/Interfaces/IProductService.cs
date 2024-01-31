using PaivaStore.Domain.Entities;

namespace PaivaStore.Domain.Interfaces;

public interface IProductService
{
    Task<List<Product>> GetAllProductsAsync();
}