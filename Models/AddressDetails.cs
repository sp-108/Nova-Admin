using System.ComponentModel.DataAnnotations;

namespace MultiStepFormApp.Models
{
    public class AddressDetails
    {
        // Correspondence Address
        public string? CorrCountry { get; set; }

        public string? CorrState { get; set; }

        public string? CorrDistrict { get; set; }

        public string? CorrAddressLine { get; set; }

        [RegularExpression(@"^[0-9]{6}$", ErrorMessage = "Invalid Pincode")]
        public string? CorrPincode { get; set; }


        // Permanent Address
        public bool SameAsCorrespondence { get; set; }

        public string? PermCountry { get; set; }
        public string? PermState { get; set; }
        public string? PermDistrict { get; set; }
        public string? PermAddressLine { get; set; }
        public string? PermPincode { get; set; }
    }
}
