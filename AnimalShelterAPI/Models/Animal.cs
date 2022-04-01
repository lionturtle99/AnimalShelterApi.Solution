using System.ComponentModel.DataAnnotations;

namespace AnimalShelterAPI.Models
{
    public class Animal
    {
        public int AnimalId { get; set; }
        [Required]
        [StringLength(25)]
        public string Name { get; set; }
        [Required]
        public string Species { get; set; }
        [Required]
        [Range(0, 2000, ErrorMessage = "Age must be between 0 and 2000.")]
        public int Age { get; set; }
        [Required]
        public string Gender { get; set; }
    }
}