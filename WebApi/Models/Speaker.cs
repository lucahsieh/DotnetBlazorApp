using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class Speaker
    {
        public string speakerId { get; set; }
        [Required]
        public string firstName { get; set; }
        [Required]
        public string lastName { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string mobileNumber { get; set; }
        [Required]
        public string areaOfSpecialization { get; set; }
        [Required]
        public string cityOfResidence { get; set; }
        [Required]
        public string provinceOfResidence { get; set; }
        [Required]
        public string employer { get; set; }
    }
}