using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Firma.Intranet.Models.Shop
{
    public class Orders
    {
        [Key]
        public int IdOrders { get; set; }

        [Required(ErrorMessage = "Write Number")]
        [MaxLength(20, ErrorMessage = "Number can be a have max 20 letters")]
        public required string Number { get; set; }

        [Required(ErrorMessage = "Write Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Write User")]
        [MaxLength(20, ErrorMessage = "User can be a have max 20 letters")]
        public required string User { get; set; }

        [Required(ErrorMessage = "Write Email")]
        [MaxLength(20, ErrorMessage = "Email can be a have max 20 letters")]
        public required string Email { get; set; }

        [Required(ErrorMessage = "Write Address")]
        [MaxLength(50, ErrorMessage = "Address can be a have max 50 letters")]
        public required string Address { get; set; }

        [Required(ErrorMessage = "Select payment method")]
        [MaxLength(20, ErrorMessage = "Payment method can be a have max 20 letters")]
        public required string PaymentMethod { get; set; }

        [Required(ErrorMessage = "Select delivery method")]
        [MaxLength(20, ErrorMessage = "Delivery method can be a have max 20 letters")]
        public required string DeliveryMethod { get; set; }

        [ForeignKey("Product")]
        public int IdProducts { get; set; }
        public Product? Product { get; set; }
    }
}
