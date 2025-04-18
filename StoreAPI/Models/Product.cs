using System.ComponentModel.DataAnnotations;

namespace StoreAPI.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        public decimal Price { get; set; }

        [Required]
        public string? Description { get; set; }

        public int Quantity { get; set; }

        public DateOnly DateOfCreation { get; set; } = DateOnly.FromDateTime(DateTime.Now);
    }
}
