using EduardShop2.Application.DTOs;
using EduardShop2.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace EduardShop2.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly ProductService _productService;

    public ProductsController(ProductService productService)
    {
        _productService = productService;
    }

    [HttpGet]
    public async Task<ActionResult> GetAll()
    {
        var products = await _productService.GetAllAsync();

        return Ok(products);
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateProductDto dto)
    {
        try
        {
            var product = await _productService.CreateAsync(dto);
            return StatusCode(201, product);
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
    }
}