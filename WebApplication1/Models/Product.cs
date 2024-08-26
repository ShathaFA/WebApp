namespace WebApplication1.Models;
using System.ComponentModel.DataAnnotations;

public class Product
    {
        // Unique identifier for the product
        public int Id { get; set; }

        // Name of the product; must be between 3 and 100 characters long
        [Required(ErrorMessage = "Product name is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 100 characters")]
        public required string Name { get; set; }

        // Price of the product; must be between 0.01 and 10,000
        [Range(0.01, 10000, ErrorMessage = "Price must be between 0.01 and 10,000")]
        public decimal Price { get; set; }

        // Description of the product; cannot be longer than 500 characters
        [StringLength(500, ErrorMessage = "Description cannot be longer than 500 characters")]
        public string? Description { get; set; }
    }
