using EduardShop2.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EduardShop2.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly IProductRepository _productRepository;

    public ProductsController(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    [HttpGet]
    public async Task<ActionResult> GetAll()
    {
        var products = await _productRepository.GetAllAsync();

        return Ok(products);
    }
}