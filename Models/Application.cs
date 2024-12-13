using System.ComponentModel.DataAnnotations;

namespace PetHouse.Models
{
    public class Application
    {
        public int Id { get; set; }

        // Not required because it will be automatically filled in
        public User? Adopter { get; set; }

        // Not required because it will be automatically filled in
        public Dog? Pet { get; set; }

        // Not required because it will be automatically filled in
        public DateOnly DateSubmission { get; set; }

        [Required]
        [StringLength(150, MinimumLength = 10)]
        public string? SubmissionMessage { get; set; }

        // Not required because it will be automatically filled in
        public DateOnly DateEvaluation { get; set; }

        [StringLength(150, MinimumLength = 10)]
        public string? EvaluationMessage { get; set; }

        /*
         * Potential values:
         *    0 = Not evaluated
         *    1 = Accepted
         *    -1 = Declined
         */
        // Not required because it will be automatically filled in
        public int Status { get; set; }
    }
}
