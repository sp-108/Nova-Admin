using System.ComponentModel.DataAnnotations;

namespace MultiStepFormApp.Models
{
    public class AddressDetails
    {
        // Correspondence Address
        [Required]
        public string CorrCountry { get; set; }

        [Required]
        public string CorrState { get; set; }

        [Required]
        public string CorrDistrict { get; set; }

        [Required]
        public string CorrAddressLine { get; set; }

        [Required]
        [RegularExpression(@"^[0-9]{6}$")]
        public string CorrPincode { get; set; }


        // Permanent Address
        public bool SameAsCorrespondence { get; set; }

        public string PermCountry { get; set; }
        public string PermState { get; set; }
        public string PermDistrict { get; set; }
        public string PermAddressLine { get; set; }
        public string PermPincode { get; set; }
    }
}
