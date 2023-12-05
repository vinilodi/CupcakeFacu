using System.ComponentModel.DataAnnotations;

namespace Cupcakecom.Models
{
    public class Products
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        public string Image { get; set; }
        [Required]
        [Display(Name = "Available")]
        public bool IsAvailable { get; set; }
    }
}
