using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Firma.Intranet.Models.CMS
{
    public class Strona
    {
        [Key] // to co będzie kluczem podstawowym tabeli
        public int IdStrony { get; set; }

        [Required(ErrorMessage = "Title are must have")] // REQUIRED - pole jest wymagane
        [MaxLength(10, ErrorMessage = "Link can a have max 10 letters")] // MAXLENGTH - maksymalna długość pola
        [Display(Name = "Title")] // to co będzie wyświetlane w formularzu
        public required string LinkTytul { get; set; }

        [Required(ErrorMessage = "Title page are must have")]
        [MaxLength(10, ErrorMessage = "Title can have max 50 letters")]
        [Display(Name = "Title page")]
        public required string Tytul { get; set; }

        [Display(Name = "Content")]
        [Column(TypeName = "nvarchar(MAX)")] // tu decydujemy jaki jest typ tego pola w bazie danych
        public required string Content { get; set; }

        [Display(Name = "Display position")]
        [Required(ErrorMessage = "Write display position")]
        public int Pozycja { get; set; }

    }
}
