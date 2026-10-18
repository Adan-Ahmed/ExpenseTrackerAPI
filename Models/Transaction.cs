using System.ComponentModel.DataAnnotations;

namespace ExpenseTrackerAPI.Models
{
    public class Transaction
    {
        public int Id { get; set; }

        [Required]
        [StringLength(60)]
        public string Title { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public enum Type 
        {
            Expense,
            Income
        }
        [Required]
        public Type typeEnume { get; set; }
        public DateOnly Date;
        public int CategoryId { get; set; }

        [Required]
        public Category category { get; set; }
    }
}
