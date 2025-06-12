using InventoryManagement.Shared.Enums;

namespace InventoryManagement.Shared.Models;

public class Product
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public ProductCategory Category { get; set; }
    public decimal Price { get; set; }
    public ProductStatus Status { get; set; }
}
