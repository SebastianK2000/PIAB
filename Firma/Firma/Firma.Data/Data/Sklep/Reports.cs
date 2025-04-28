using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Data.Data.Sklep
{
    public class Reports
    {
        [Key]
        public int IdReports { get; set; }

        [Required(ErrorMessage = "Write Title")]
        [MaxLength(20, ErrorMessage = "Title can be a have max 20 letters")]
        public required string Title { get; set; }

        [Required(ErrorMessage = "Write Description")]
        [MaxLength(100, ErrorMessage = "Description can be a have max 100 letters")]
        public required string Description { get; set; }

        [Required(ErrorMessage = "Write Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; } = DateTime.Now;

        [MaxLength(20, ErrorMessage = "User can be a have max 20 letters")]
        public string User { get; set; } = string.Empty;

        [MaxLength(20, ErrorMessage = "Product can be a have max 20 letters")]
        public string Product { get; set; } = string.Empty;

    }
}
