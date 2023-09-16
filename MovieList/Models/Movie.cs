using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace MovieList.Models
{  
    
    public class Movie
    {

        public int movieId { get; set; }

        [Required(ErrorMessage = "Please enter a genre.")] 
        public string genreId { get; set; } = string.Empty;

        [ValidateNever]
        public Genre Genre { get; set; } = null!;

        [Required(ErrorMessage = "Please enter a name.")]
        public string title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Enter a year")]
        [Range(1920, 2023, ErrorMessage = "Year must be between 1920 and the current year")]
        public int? year { get; set; }

        [Required(ErrorMessage = "Please enter a rating.")]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]
        public int? rating { get; set; }

        public string Slug => title?.Replace(' ', '-').ToLower() + '-' + year?.ToString();
    }
}
