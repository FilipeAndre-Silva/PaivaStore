using PaivaStore.Application.Dtos.Product.Response;

namespace PaivaStore.Application.Interfaces;

public interface IProductApplicationService
{
    Task<List<ProductResponse>> GetAllProductsAsync();
}
