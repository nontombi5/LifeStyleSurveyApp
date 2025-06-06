using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LifestyleSurveyApp.Models
{
    public class Survey
    {
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid email address format.")]
        [StringLength(150, ErrorMessage = "Email cannot be longer than 150 characters.")]

        public string Email { get; set; }

        [Required]
        [RegularExpression(@"^\d{10,15}$", ErrorMessage = "Contact number must be digits only (10 to 15 digits).")]
        public string ContactNumber { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [NotMapped]
        public int Age => DateTime.Now.Year - DateOfBirth.Year -
                      (DateTime.Now.DayOfYear < DateOfBirth.DayOfYear ? 1 : 0);



        public bool Pizza { get; set; }
        public bool Pasta { get; set; }
        public bool PapAndWors { get; set; }
        public bool Other { get; set; }

        
        [Range(1, 5,ErrorMessage = "Please select a rating")]
        public int EatOut { get; set; }

        [Range(1, 5, ErrorMessage = "Please select a rating")]
        public int WatchMovies{ get; set; }

        [Range(1, 5, ErrorMessage = "Please select a rating")]
        public int WatchTV{ get; set; }

        [Range(1, 5, ErrorMessage = "Please select a rating")]
        public int ListenToRadio { get; set; }
    }
}
