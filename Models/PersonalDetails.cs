using System.ComponentModel.DataAnnotations;

namespace MultiStepFormApp.Models
{
    public enum Gender
    {
        Male,
        Female,
        Other
    }

    public enum IsMarried
    {
        Married,
        Unmarried
    }
    public class PersonalDetails
    {
        // ---------- NAME ----------
        [Required(ErrorMessage = "First name is required")]
        [RegularExpression(@"^[A-Za-z]+$", ErrorMessage = "Only alphabets allowed")]
        public string FirstName { get; set; }

        [RegularExpression(@"^[A-Za-z]*$", ErrorMessage = "Only alphabets allowed")]
        public string? MiddleName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [RegularExpression(@"^[A-Za-z]+$", ErrorMessage = "Only alphabets allowed")]
        public string LastName { get; set; }


        // ---------- DOB & AGE ----------
        [Required(ErrorMessage = "Date of Birth required")]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        // Calculated property (not stored in DB)
        public int Age
        {
            get
            {
                var today = DateTime.Today;
                var age = today.Year - DOB.Year;
                if (DOB.Date > today.AddYears(-age)) age--;
                return age;
            }
        }


        // ---------- CONTACT ----------
        [Required]
        [RegularExpression(@"^\+91[0-9]{10}$", ErrorMessage = "Enter mobile like +919876543210")]
        public string MobileNumber { get; set; }


        // ---------- AADHAAR ----------
        [Required]
        [RegularExpression(@"^[0-9]{12}$", ErrorMessage = "Aadhaar must be 12 digits")]
        public string AadhaarNumber { get; set; }


        // ---------- PARENTS ----------
        [Required]
        [RegularExpression(@"^[A-Za-z ]+$", ErrorMessage = "Only alphabets allowed")]
        public string FatherName { get; set; }

        [Required]
        [RegularExpression(@"^[A-Za-z ]+$", ErrorMessage = "Only alphabets allowed")]
        public string MotherName { get; set; }


        // ---------- EXTRA DETAILS ----------
        [Required]
        public string FatherOccupation { get; set; }

        [Required]
        public string MotherOccupation { get; set; }

        [Required]
        public string Hobbies { get; set; }

        [Required]
        public string Nationality { get; set; }

        [Required]
        public Gender Gender { get; set; }

        [Required]
        public IsMarried IsMarried { get; set; }


    }
}
