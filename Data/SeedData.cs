using Microsoft.EntityFrameworkCore;
using PetHouse.Models;

namespace PetHouse.Data
{
    public class SeedData
    {
        private static void InitDogDB(PetHouseContext con)
        {
            if ( con.Dog == null )
            {
                throw new NullReferenceException(
                    "Null Dog DBSet");
            }

            // Exit if Dog DB is not empty
            if ( con.Dog.Any() ) { return; }

            con.Dog.AddRange(
                new Dog
                {
                    DogName = "Chewy",
                    DogBreed = "Cocker Spaniel",
                    DogAge = 12,
                    DogSize = "Medium",
                    DogWeight = 30.0,
                    DogColor = "Multicolor",
                    DogPersonality = "Lazy",
                    DogIsFriendlyWithChildren = true,
                    DogIsFriendlyWithCats = true,
                    DogHealthInformation = "Terminal case of cuteness!!!!",
                    DogIsAdopted = false,
                    DogPicture = "/DogPictures/1.jpg",
                    Adopter = null
                },
                new Dog
                {
                    DogName = "Pochi",
                    DogBreed = "Shiba Inu",
                    DogAge = 4,
                    DogSize = "Medium",
                    DogWeight = 22.5,
                    DogColor = "Cream",
                    DogPersonality = "Energetic",
                    DogIsFriendlyWithChildren = true,
                    DogIsFriendlyWithCats = false,
                    DogHealthInformation = "Healthy",
                    DogIsAdopted = false,
                    DogPicture = "/DogPictures/2.jpg",
                    Adopter = null
                },
                new Dog
                {
                    DogName = "Marbles",
                    DogBreed = "Chihuahua",
                    DogAge = 16,
                    DogSize = "Small",
                    DogWeight = 4.7,
                    DogColor = "Multicolor",
                    DogPersonality = "Dumb but affectionate",
                    DogIsFriendlyWithChildren = true,
                    DogIsFriendlyWithCats = false,
                    DogHealthInformation = "Old, but otherwise healthy",
                    DogIsAdopted = false,
                    DogPicture = "/DogPictures/3.jpg",
                    Adopter = null
                },
                new Dog
                {
                    DogName = "Charlotte",
                    DogBreed = "Unknown",
                    DogAge = 7,
                    DogSize = "Small",
                    DogWeight = 9.2,
                    DogColor = "Gray",
                    DogPersonality = "Aloof",
                    DogIsFriendlyWithChildren = true,
                    DogIsFriendlyWithCats = true,
                    DogHealthInformation = "Weird looking dog... might be sick?",
                    DogIsAdopted = false,
                    DogPicture = "/DogPictures/4.jpg",
                    Adopter = null
                }
            );

            con.SaveChanges();
        }

        private static void InitUserDB(PetHouseContext con)
        {
            if (con.User == null)
            {
                throw new NullReferenceException(
                    "Null User DBSet");
            }

            // Exit if User DB is not empty
            if (con.User.Any()) { return; }

            con.User.AddRange(
                new User
                {
                    Username = "user",
                    Password = "Password=123",
                    FirstName = "Jane",
                    LastName = "Smith",
                    Email = "smith.jane@yahoo.com",
                    Phone = "(123) 456-7890",
                    Age = 30,
                    Location = "Fargo, ND",
                    AnnualIncome = 45000.00,
                    NumPreownedPets = 1,
                    NumDogsAdoptedThisCalendarYear = 0,
                    UserIsAdmin = false
                },
                new User
                {
                    Username = "admin",
                    Password = "123=Password",
                    FirstName = "Smith",
                    LastName = "Johnson",
                    Email = "smith.johnson@google.com",
                    Phone = "(987) 654-3210",
                    Age = 24,
                    Location = "Fargo, ND",
                    AnnualIncome = 60000.00,
                    NumPreownedPets = 3,
                    NumDogsAdoptedThisCalendarYear = 0,
                    UserIsAdmin = true
                },
                new User
                {
                    Username = "tmendoza",
                    Password = "pass-w0rd",
                    FirstName = "Tyler",
                    LastName = "Mendoza",
                    Email = "tyler.mendoza@ndsu.edu",
                    Phone = "(000) 000-0000",
                    Age = 23,
                    Location = "Fargo, ND",
                    AnnualIncome = 25000.00,
                    NumPreownedPets = 0,
                    NumDogsAdoptedThisCalendarYear = 0,
                    UserIsAdmin = false
                }
            );

            con.SaveChanges();
        }

        private static void InitApplicationDB(PetHouseContext con)
        {
            if (con.Application == null)
            {
                throw new NullReferenceException(
                    "Null Application DBSet");
            }

            // Exit if Application DB is not empty
            if (con.Application.Any()) { return; }

            con.Application.AddRange(
                new Application
                {
                    Adopter = con.User.Where(u => u.Username == "tmendoza").First(),
                    Pet = con.Dog.Where(d => d.DogName == "Chewy").First(),
                    DateSubmission = DateOnly.FromDateTime(DateTime.Now),
                    SubmissionMessage = "He was the family dog I had when I was a kid :)",
                    DateEvaluation = DateOnly.MinValue,
                    EvaluationMessage = null,
                    Status = 0
                }
            );

            con.SaveChanges();
        }

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new PetHouseContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<PetHouseContext>>()
            );

            if ( context == null )
            {
                throw new NullReferenceException(
                    "Null PetHouseDBContext");
            }
            else
            {
                InitUserDB(context);
                InitDogDB(context);
                InitApplicationDB(context);
            }
        }
    }
}
