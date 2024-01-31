using Microsoft.EntityFrameworkCore;
using PaivaStore.Domain.Entities;
using PaivaStore.Domain.Interfaces.Repositories;
using PaivaStore.Infra.Data;

namespace PaivaStore.Infra.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly PaivaStoreDbContext _context;

    public ProductRepository(PaivaStoreDbContext context)
    {
        _context = context;
    }

    public async Task<List<Product>> GetAllProductsAsync()
    {
        return await _context.Products.ToListAsync();
    }
}