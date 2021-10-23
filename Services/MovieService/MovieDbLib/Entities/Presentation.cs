using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MovieDbLib.Entities
{
    public class Presentation
    {
        //should be composite key
        public int Id { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public int RoomId { get; set; }
        public string StartTime { get; set; }
    }
    
    public class PresentationEntityTypeConfiguration : IEntityTypeConfiguration<Presentation>
    {
        public void Configure(EntityTypeBuilder<Presentation> builder)
        {
            builder.ToTable("presentation"); 
        }
    }
}
