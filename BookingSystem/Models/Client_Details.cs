using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookingSystem.Models
{
    public class Client_Details
    {
        [Key]
        public int ClientId { get; set; }

        [Required(ErrorMessage = "Client Name is required")]
        [StringLength(100)]
        public string ClientName { get; set; }

        [Required(ErrorMessage = "Client Email Id is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string? ClientEmailId { get; set; }

        [Required(ErrorMessage = "Client Mobile No. is required")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Invalid Phone Number")]
        public string? ClientNumber { get; set; }

        [Required(ErrorMessage = "Client Pan CARD No. is required")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Pan CARD No. must be 10 characters")]
        public string? ClientPanNo { get; set; }

        [Required(ErrorMessage = "Client Aadhar Card No. is required")]
        [StringLength(12, MinimumLength = 12, ErrorMessage = "Aadhar Card No. must be 12 characters")]
        public string? ClientAadharNo { get; set; }

        [Required(ErrorMessage = "Select at least one preferred floor")]
        public string PreferFloors1 { get; set; }

        public string? PreferFloors2 { get; set; } = null;

        public string? PreferFloors3 { get; set; } = null;

        [Required(ErrorMessage = "Area Preference is required")]
        public string? AreaPreference { get; set; }

        // Channel Partner details
        public string? CpName { get; set; } = null;

        public string? CpEmailId { get; set; } = null;

        public string? CpNumber { get; set; } = null;

        [Required(ErrorMessage = "RERA Number is required")]
        public string CpCompanyNameWithRERA { get; set; }

        // Bank details
        public string? BankName { get; set; } = null;

        public string? ChequeNumber { get; set; } = null;

        public DateTime? ChequeDate { get; set; } = null;

        public decimal? ChequeAmount { get; set; } = null;

        // Created DateTime
        [DataType(DataType.DateTime)]
        [Required]
        public DateTime CreatedDateTime { get; set; }

        // Constructor
        public Client_Details()
        {
            CreatedDateTime = DateTime.Now;
        }
    }
}
