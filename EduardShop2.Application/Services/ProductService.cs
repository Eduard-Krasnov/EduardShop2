using EduardShop2.Application.DTOs;
using EduardShop2.Application.Interfaces;
using EduardShop2.Domain.Entities;

namespace EduardShop2.Application.Services;

public class ProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<List<Product>> GetAllAsync()
    {
        return await _productRepository.GetAllAsync();
    }

    public async Task<Product> CreateAsync(CreateProductDto dto)
    {
        if (string.IsNullOrWhiteSpace(dto.Name) || dto.Price <= 0)
            throw new ArgumentException("Invalid product data");

        var product = new Product
        {
            Name = dto.Name,
            Price = dto.Price
        };

        return await _productRepository.AddAsync(product);
    }

    public async Task<Product?> UpdateAsync(int id, UpdateProductDto dto)
    {
        if (string.IsNullOrWhiteSpace(dto.Name) || dto.Price <= 0)
            throw new ArgumentException("Invalid product data");

        var product = await _productRepository.GetByIdAsync(id);
        if (product == null)
            return null;

        product.Name = dto.Name;
        product.Price = dto.Price;

        return await _productRepository.UpdateAsync(product);
    }

}