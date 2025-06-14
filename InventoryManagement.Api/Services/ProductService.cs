using InventoryManagement.Api.Data;
using InventoryManagement.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Api.Services;

public class ProductService(AppDbContext context)
{
    private readonly AppDbContext _context = context;
    public async Task<IEnumerable<Product>> GetAllProductsAsync()
    {
        if (_context.Products == null)    
            return [];        

        return await _context.Products.ToListAsync();
    }
}
