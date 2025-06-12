using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Shared.Enums;

public enum ProductCategory
{
    [Display(Name = "Roupas")]
    Clothing,

    [Display(Name = "Sapatos")]
    Shoes,

    [Display(Name = "Bolsas")]
    Bag,

    [Display(Name = "Jóias")]
    Jewelry,

    [Display(Name = "Acessórios")]
    Acessories
}
