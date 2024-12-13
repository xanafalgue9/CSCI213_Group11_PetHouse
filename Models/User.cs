using System.ComponentModel.DataAnnotations;

namespace PetHouse.Models
{
    public class User
    {
        public int Id { get; set; }
       
        [Required]
        [StringLength(30, MinimumLength = 4)]
        public string? Username { get; set; }

        /*
         * Password requirements:
         *     At least 8 characters
         *     At most 30 characters
         *     Contains a letter
         *     Contains a number
         *     Contains one of the following symbols:
         *         ! @ # $ % ^ & * - _ + = : , . ?
         */
        [Required]
        [StringLength(30, MinimumLength = 8)]
        [RegularExpression(@"(?=.*[a-zA-Z])(?=.*\d)(?=.*[!@#$%^&*\-_+=:,.?]).*",
            ErrorMessage = "Password does not have all required elements.")]
        public string? Password { get; set; }

        [Required]
        [StringLength(24, MinimumLength = 3)]
        public string? FirstName { get; set; }

        [Required]
        [StringLength(40, MinimumLength = 4)]
        public string? LastName { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 5)]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 10)]
        [Phone]
        public string? Phone { get; set; }

        [Required]
        [Range(0, 100)]
        public int Age { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 10)]
        public string? Location { get; set; }

        [Required]
        [Range(0, 1000000)] // $0 - $1,000,000
        public double? AnnualIncome{ get; set; }

        [Required]
        [Range(0,10)]   // 0-10 pets they already have
        public int? NumPreownedPets { get; set; }
    }
}
