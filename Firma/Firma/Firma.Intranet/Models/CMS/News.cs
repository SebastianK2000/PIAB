using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Firma.Intranet.Models.CMS
{
    public class News
    {
        [Key]
        public int IdNews { get; set; }

        [Required(ErrorMessage = "Title are must have")]
        [MaxLength(10, ErrorMessage = "Link can a have max 10 letters")]
        [Display(Name = "Title")]
        public required string LinkTytul { get; set; }

        [Required(ErrorMessage = "Title News are must have")]
        [MaxLength(10, ErrorMessage = "Title News can have max 50 letters")]
        [Display(Name = "Title News")]
        public required string Tytul { get; set; }

        [Display(Name = "Content")]
        [Column(TypeName = "nvarchar(MAX)")]
        public required string Content { get; set; }

        [Display(Name = "Display position")]
        [Required(ErrorMessage = "Write display position")]
        public int Position { get; set; }
    }
}
