using System.ComponentModel.DataAnnotations;

namespace BlazorClient.Models
{
    public class Speaker
    {
        public string speakerId { get; set; }
        [Required]
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "First Name should be alphabetical")]
        public string firstName { get; set; }
        [Required]
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Last Name should be alphabetical")]
        public string lastName { get; set; }
        [Required]
        [EmailAddress]
        public string email { get; set; }
        [Required]
        [Phone]
        public string mobileNumber { get; set; }
        [Required]
        public string areaOfSpecialization { get; set; }
        [Required]
        public string cityOfResidence { get; set; }
        [Required]
        [RegularExpression("^[a-zA-Z]{2}", ErrorMessage = "Province should be exact two letters e.g. BC, WA")]
        public string provinceOfResidence { get; set; }
        [Required]
        public string employer { get; set; }
    }
}