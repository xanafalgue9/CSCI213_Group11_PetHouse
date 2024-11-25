﻿using System.ComponentModel.DataAnnotations;

namespace PetHouse.Models
{
    public class Dog
    {
        // change 

        public int Id { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 3)]
        public string? DogName { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string? DogBreed { get; set; }

        [Required]
        [Range(1, 20)]
        public int DogAge { get; set; }

        /*
         * Small: 12 inches or less in height, and typically weigh 10–25 pounds
            Medium: 12–16 inches in height, and typically weigh 25–55–60 pounds
            Large: 17–20 inches in height, and typically weigh 55–90 pounds
            Giant: Over 90 pounds in weight
        */


        [Required]
        [StringLength(8, MinimumLength = 4)]
        public string? DogSize { get; set; }

        [Required]
        [Range(1, 80)]
        public double DogWight { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 2)]
        public string? DogColor { get; set; }

        [Required]
        [StringLength(150, MinimumLength = 2)]
        public string? DogPersonality { get; set; }

        [Required]
        [StringLength(5, MinimumLength = 2)]   // yes, no
        public string? DogFriendlyWithChildren { get; set; }

        [Required]
        [StringLength(5, MinimumLength = 2)]   // yes, no
        public string? DogFriendlyWithCats { get; set; }

        [Required]
        [StringLength(150, MinimumLength = 2)]
        public string? DogHealthInformation { get; set; }

        [Required]
        [StringLength(150, MinimumLength = 4)]
        public string? DogStatus { get; set; }
    }
}
