using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ExpenseTrackerAPI.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [StringLength (60)]
        public string Name { get; set; } = string.Empty;
    }
}
