using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Item
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public string? Description { get; set; }
        public bool IsComplete { get; set; }
    }
}