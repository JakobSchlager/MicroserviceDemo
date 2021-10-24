using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Reflection;

namespace MovieDbLib.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }
        public int Length { get; set; }
        public string ReleaseDate { get; set; }
        public int AgeRestriction { get; set; }
        public string Image { get; set; }
    }

    public class MovieEntityTypeConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.ToTable("movie"); 

            dynamic movies = JArray.Parse(File.ReadAllText($"{Assembly.GetExecutingAssembly().Location}\\..\\Files\\movies.json"));
                
            int pK = 1;
            foreach(var movie in movies)
            {
                builder.HasData(new Movie
                {
                    Id = pK,
                    AgeRestriction = bool.Parse(movie.adult.ToString()) ? 18 : 0,
                    Description = movie.overview,
                    Title = movie.title,
                    Language = movie.original_language,
                    ReleaseDate = movie.release_date,
                    Length = 100,
                    Image = "https://image.tmdb.org/t/p/w500"+movie.poster_path,
                }); 
                pK++; 
            }
        }
    }
}
