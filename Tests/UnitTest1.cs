using EduardShop2.Application.Interfaces;
using EduardShop2.Application.Services;
using EduardShop2.Domain.Entities;
using Moq;

namespace EduardShop2.Tests;

public class ProductServiceTests
{
    [Fact]
    public async Task GetAllAsync_ReturnsProducts()
    {
        // ARRANGE
        var products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Price = 1000 },
            new Product { Id = 2, Name = "Mouse", Price = 50 }
        };

        var repositoryMock = new Mock<IProductRepository>();

        repositoryMock
            .Setup(r => r.GetAllAsync())
            .ReturnsAsync(products);

        var service = new ProductService(repositoryMock.Object);

        // ACT
        var result = await service.GetAllAsync();

        // ASSERT
        Assert.Equal(2, result.Count);
    }
}

/*
public class ProductServiceTests
{
    [Fact]
    public async Task GetAllAsync_ReturnsProducts()
    {
        // ARRANGE
        var fakeRepository = new FakeProductRepository();
        var service = new ProductService(fakeRepository);

        // ACT
        var result = await service.GetAllAsync();

        // ASSERT
        Assert.Equal(2, result.Count);
    }
}

public class FakeProductRepository : IProductRepository
{
    public Task<List<Product>> GetAllAsync()
    {
        var products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Price = 1000 },
            new Product { Id = 2, Name = "Mouse", Price = 50 }
        };

        return Task.FromResult(products);
    }
}
*/