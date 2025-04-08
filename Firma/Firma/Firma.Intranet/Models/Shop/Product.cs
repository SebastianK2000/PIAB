using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Firma.Intranet.Models.Shop
{
    public class Product
    {
        [Key]
        public int IdProduct { get; set; }

        [Required(ErrorMessage = "Write Name")]
        public required string Name { get; set; }

        [Required(ErrorMessage = "Write Price of product")]
        [Column(TypeName = "money")]
        public decimal Price { get; set; }
        public int IdKind { get; set; }
        public string Color { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "Add Image")]
        [Display(Name = "Select Image")]
        public required string ImageUrl { get; set; }

        // Relacja jeden do wielu
        // Kod po stronie jeden

        [ForeignKey("Kind")]
        public int IdKinds { get; set; }
        public Kind? Kind { get; set; }

        public ICollection<Orders> Orders { get; } = new List<Orders>();
    }
}
