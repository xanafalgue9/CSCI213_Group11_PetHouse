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
        public DateOnly DateSubmission { get; set; }

        [Required]
        public DateOnly? DateEvaluation { get; set; }

        [Required]
        [StringLength(150, MinimumLength = 10)]
        public string? EvaluationMessage { get; set; }

        /*
         * Potential values:
         *    0 = Not evaluated
         *    1 = Accepted
         *    -1 = Declined
         */
        [Required]
        public int Status { get; set; }
    }
}
