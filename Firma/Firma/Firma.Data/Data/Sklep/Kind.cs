using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Data.Data.Sklep
{
    public class Kind
    {
        [Key]
        public int IdKind { get; set; }

        [Required(ErrorMessage = "Title are must have")]
        [MaxLength(30, ErrorMessage = "Kind of product can have a 30 letters")]

        public required string Name { get; set; }

        public string Description { get; set; } = string.Empty;

        // Relacja jeden do wielu
        // Kod po stronie wielu

        public ICollection<Product> Product { get; } = new List<Product>();
    }
}
