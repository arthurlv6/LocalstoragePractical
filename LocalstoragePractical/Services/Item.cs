using System.ComponentModel.DataAnnotations;

namespace LocalstoragePractical.Services
{
    public class Item
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than {0}")]
        public int Quantity { get; set; }
        [Required]
        public double Price { get; set; }
    }
}

