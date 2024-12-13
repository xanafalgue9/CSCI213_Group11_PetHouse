using System.ComponentModel.DataAnnotations;

namespace PetHouse.Models
{
    /*
     * STOPGAP CLASS
     */
    public class User
    {
        public int Id { get; set; }
       
        //We might need this?
        [Required]
        [StringLength(50, MinimumLength = 10)]
        [Phone]
        public string? Phone { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 10)]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 4)]
        public string? Username { get; set; }

        [Required]
        [StringLength(24, MinimumLength = 3)]
        public string? FirstName { get; set; }

        [Required]
        [StringLength(40, MinimumLength = 4)]
        public string? LastName { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 10)]
        public string? Location { get; set; }

        [Required]
        [Range(0, 1000000)] //$0 - $1,000,000
        public double? AnnualIncome{ get; set; }

        [Required]
        [Range(0,3)]   // 0-3 pets they already have
        public int? NumPreownedPets { get; set; }
    }
}
