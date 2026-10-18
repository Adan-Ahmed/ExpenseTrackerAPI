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
        public enum TransactionType
        {
            Expense,
            Income
        }
        [Required]
        public TransactionType Type { get; set; }
        public DateOnly Date {  get; set; }
        public int CategoryId { get; set; }

        [Required]
        public Category Category { get; set; }
    }
}
