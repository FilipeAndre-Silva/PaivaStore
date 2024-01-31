using AutoMapper;
using PaivaStore.Application.Dtos.Product.Response;
using PaivaStore.Application.Interfaces;
using PaivaStore.Domain.Interfaces;

namespace PaivaStore.Application.Services;

public class ProductApplicationService : IProductApplicationService
{
    private readonly IMapper _mapper;
    private readonly IProductService _productService;
    public ProductApplicationService(IMapper mapper, IProductService productService)
    {
        _mapper = mapper;
        _productService = productService;
    }

    public async Task<List<ProductResponse>> GetAllProductsAsync()
    {
        var result = await _productService.GetAllProductsAsync();
        return  _mapper.Map<List<ProductResponse>>(result);
    }
}