using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Shared.Enums;

public enum ProductStatus
{
    [Display(Name = "Ativo")]
    Active,

    [Display(Name = "Fora de Estoque")]
    OutOfStock,
}
