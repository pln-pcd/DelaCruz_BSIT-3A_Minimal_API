using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductApi.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; } = string.Empty;

        public decimal Price { get; set; }

        // --- Relationships Apply Here ---
        
        // Link to Category
        [Required]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        // Link to Supplier
        [Required]
        public int SupplierId { get; set; }
        public Supplier? Supplier { get; set; }
    }
}