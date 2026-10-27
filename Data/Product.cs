using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodBazaar.Data;

public class Product
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Range(0.01, 1000, ErrorMessage = "Price must be between 0.01 and 1000")]
    public decimal Price { get; set; }

    public string? Description { get; set; }
    public string? SpecialTag { get; set; }

    public string? ImageUrl { get; set; }

    public int CategoryId { get; set; }

    // navigation property for the category
    [ForeignKey("CategoryId")]
    public Category Category { get; set; }
}
