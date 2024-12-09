using System.ComponentModel.DataAnnotations;

namespace PetHouse.Models
{
    public class Application
    {
        public int Id { get; set; }

        [Required]
        public User Adopter { get; set; }

        [Required]
        public Dog Pet { get; set; }

        [Required]
        public DateOnly Date { get; set; }

        [Required]
        [StringLength(150, MinimumLength = 10)]
        public string Message { get; set; }

        /*
         * Potential values:
         *    "NOT EVALUATED"
         *    "ACCEPTED"
         *    "DECLINED"
         */
        [Required]
        public string Status { get; set; }
    }
}
