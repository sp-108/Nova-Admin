using System.ComponentModel.DataAnnotations;

namespace MultiStepFormApp.Models
{
    public class FormEntry
    {
        [Key]
        public int Id { get; set; }

        // Personal
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public int Age { get; set; }
        public string Mobile { get; set; }
        public string Aadhaar { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string FatherOccupation { get; set; }
        public string MotherOccupation { get; set; }
        public string Hobbies { get; set; }

        public string Nationality { get; set; }

        // Address
        public string CorrAddress { get; set; }
        public string CorrDistrict { get; set; }
        public string CorrState { get; set; }
        public string CorrCountry { get; set; }
        public string CorrPincode { get; set; }

        public string PermAddress { get; set; }
        public string PermDistrict { get; set; }
        public string PermState { get; set; }
        public string PermCountry { get; set; }
        public string PermPincode { get; set; }

        // Stored JSON education (simple approach)
        public string EducationJson { get; set; }
    }
}
