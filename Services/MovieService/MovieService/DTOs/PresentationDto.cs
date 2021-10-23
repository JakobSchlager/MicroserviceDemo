namespace MovieService.DTOs
{
    public class PresentationDto
    {
        //should be composite key
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int RoomId { get; set; }
        public string StartTime { get; set; }
    }
}
