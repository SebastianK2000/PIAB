using System.ComponentModel.DataAnnotations;

namespace Firma.Intranet.Models.Shop
{
    public class Support
    {
        [Key]
        public int IdSupport { get; set; }

        [Required(ErrorMessage = "Write Name")]
        [MaxLength(20, ErrorMessage = "Name can be a have max 20 letters")]
        public required string Name { get; set; }

        [Required(ErrorMessage = "Write Email")]
        [MaxLength(20, ErrorMessage = "Email can be a have max 20 letters")]
        public required string Email { get; set; }

        [Required(ErrorMessage = "Write Phone")]
        [MaxLength(10, ErrorMessage = "Phone can be a have max 10 letters")]
        public required string Phone { get; set; }

        [Required(ErrorMessage = "Write Address")]
        public required string Address { get; set; }

        [Required(ErrorMessage = "Write Description")]
        public required string Description { get; set; }
    }
}
