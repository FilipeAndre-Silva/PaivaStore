using Microsoft.AspNetCore.Mvc;
using PaivaStore.Application.Interfaces;

namespace PaivaStore.Api.Controllers;

[ApiController]
[Route("api/product")]
public class ProductController : ControllerBase
{
    private readonly IProductApplicationService _productApplicationService;

    public ProductController(IProductApplicationService productApplicationService)
    {
        _productApplicationService = productApplicationService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        var result = await _productApplicationService.GetAllProductsAsync();

        if (!result.Any()) return NoContent();

        return Ok(result);
    }
}