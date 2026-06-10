using EduardShop2.Application.Interfaces;
using EduardShop2.Domain.Entities;
using EduardShop2.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace EduardShop2.Infrastructure.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly ShopDbContext _context;

    public ProductRepository(ShopDbContext context)
    {
        _context = context;
    }

    public async Task<List<Product>> GetAllAsync()
    {
        return await _context.Products.ToListAsync();
    }
}