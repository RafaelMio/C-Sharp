using System.ComponentModel.DataAnnotations;

namespace Expenses.Models
{
    public class Expense
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public string Description { get; set; } = null!;

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Amount needs to be higher than 0 !")]
        public double Amount { get; set; }

        [Required]
        public String Category { get; set; } = null!;

        public DateTime Date { get; set; } = DateTime.Now;
    }
}
