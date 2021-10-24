namespace MovieService.DTOs
{
    public class MovieDto
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
}
