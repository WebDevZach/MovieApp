using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore;



namespace MovieList.Models
{
    public class MoviesContext : DbContext
    {
        public MoviesContext(DbContextOptions<MoviesContext> options) : base(options)
        { }

        public DbSet<Movie> Movies { get; set; } = null!;
        public DbSet<Genre> Genres { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Genre>().HasData(
                new Genre { genreId = "A", name = "Action" },
                new Genre { genreId = "C", name = "Comedy" },
                new Genre { genreId = "D", name = "Drama" },
                new Genre { genreId = "H", name = "Horror" },
                new Genre { genreId = "M", name = "Musical" },
                new Genre { genreId = "R", name = "RomCom" },
                new Genre { genreId = "S", name = "SciFi" });


            modelBuilder.Entity<Movie>().HasData(
           new Movie
           {
               movieId = 1,
               title = "Casablanca",
               year = 1942,
               rating = 5,
               genreId = "D"


           },
           new Movie
           {
               movieId = 2,
               title = "Wonder Woman",
               year = 2017,
               rating = 3,
               genreId = "A"
           },
             new Movie
             {
                 movieId = 3,
                 title = "Moonstruck",
                 year = 1988,
                 rating = 4, 
                 genreId = "R"
             });

        }
    }
}
