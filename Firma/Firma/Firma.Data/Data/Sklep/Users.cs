using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Firma.Data.Data.Sklep
{
    public class Users
    {
        [Key]
        public int IdUser { get; set; }

        [Required(ErrorMessage = "Write Name")]
        [MaxLength(20, ErrorMessage = "Name can be a have max 20 letters")]
        public required string Name { get; set; }

        [Required(ErrorMessage = "Write Surname")]
        [MaxLength(20, ErrorMessage = "Surname can be a have max 20 letters")]
        public required string Surname { get; set; }

        [Required(ErrorMessage = "Write Email")]
        [MaxLength(30, ErrorMessage = "Email can be a have max 30 letters")]
        public required string Email { get; set; }

        [Required(ErrorMessage = "Write Phone")]
        [MaxLength(12, ErrorMessage = "Phone can be a have max 12 letters")]
        public required string Phone { get; set; }

        [Required(ErrorMessage = "Write Address")]
        [MaxLength(50, ErrorMessage = "Address can be a have max 50 letters")]
        public required string Address { get; set; }

        [Required(ErrorMessage = "Write City")]
        [MaxLength(20, ErrorMessage = "City can be a have max 20 letters")]
        public required string City { get; set; }

        [Display(Name = "Postal code")]
        [Required(ErrorMessage = "Write Postal code")]
        [MaxLength(10, ErrorMessage = "Postal code can be a have max 10 letters")]
        public required string PostalCode { get; set; }

        [Required(ErrorMessage = "Write Country")]
        [MaxLength(20, ErrorMessage = "Country can be a have max 20 letters")]
        public required string Country { get; set; }

        [Required(ErrorMessage = "Write Password")]
        [MaxLength(20, ErrorMessage = "Password can be a have max 20 letters")]
        public required string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [Required(ErrorMessage = "Write Confirm Password")]
        [MaxLength(20, ErrorMessage = "Confirm Password can be a have max 20 letters")]
        [Compare("Password", ErrorMessage = "Password and Confirm Password are not the same")]
        public required string ConfirmPassword { get; set; }

        [Display(Name = "Date of Birth")]
        [Required(ErrorMessage = "Write Date of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; } = DateTime.Now;
    }
}
