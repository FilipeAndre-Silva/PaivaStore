using PaivaStore.Domain.Entities;
using PaivaStore.Domain.Interfaces;
using PaivaStore.Domain.Interfaces.Repositories;

namespace PaivaStore.Domain.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _repository;
    public ProductService(IProductRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<Product>> GetAllProductsAsync()
    {
        return await _repository.GetAllProductsAsync();
    }
}