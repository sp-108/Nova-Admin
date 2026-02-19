using System.ComponentModel.DataAnnotations;

namespace MultiStepFormApp.Models
{
    public class EducationDetail
    {
        [Required]
        public EducationType EducationType { get; set; }

        [Required]
        public string InstituteName { get; set; }

        [Required]
        public string BoardOrUniversity { get; set; }

        [Required]
        [Range(1900, 2100)]
        public int PassingYear { get; set; }

        [Required]
        [Range(0, 100)]
        public double Percentage { get; set; }

        public string Specialization { get; set; }
    }
}
