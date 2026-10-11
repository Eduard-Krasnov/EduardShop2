using EduardShop2.Domain.Entities;

namespace EduardShop2.Application.Interfaces;

public interface IProductRepository
{
    Task<List<Product>> GetAllAsync();
    Task<Product> AddAsync(Product product);
}