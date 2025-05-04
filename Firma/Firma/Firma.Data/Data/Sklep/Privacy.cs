using System.ComponentModel.DataAnnotations;

namespace Firma.Data.Data.Sklep
{
    public class Privacy
    {
        [Key]
        public int IdPrivacy { get; set; }

        [Required]
        public string PageName { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Introduction { get; set; }

        [Required]
        public string InformationWeCollect { get; set; }

        [Required]
        public string HowWeUseInformation { get; set; }

        [Required]
        public string DataSecurity { get; set; }

        [Required]
        public string Cookies { get; set; }

        [Required]
        public string ThirdPartyDisclosure { get; set; }

        [Required]
        public string YourConsent { get; set; }
    }
}
