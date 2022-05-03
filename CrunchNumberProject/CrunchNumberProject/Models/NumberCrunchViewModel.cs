using System;
using System.ComponentModel.DataAnnotations;

namespace CrunchNumberProject.Models
{
    public class NumberCrunchViewModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Sample Max Count")]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]
        public int SampleMaxCount { get; set; }

        [Required]
        [Display(Name = "Patient Score")]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]
        public int PatientScore { get; set; }

        [Required]
        [Display(Name = "Doctore Score")]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]
        public int DoctoreScore { get; set; }

        [Required]
        [Display(Name = "Upload Score")]

        public string UploadScore { get; set; }
    }
}
