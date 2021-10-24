using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

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

            builder.HasData(new Presentation
            {
                Id = 1,
                MovieId = 1,
                RoomId = 1,
                StartTime = DateTime.Today.AddDays(1).ToString(), 
            });  
            builder.HasData(new Presentation
            {
                Id = 2,
                MovieId = 2,
                RoomId = 2,
                StartTime = DateTime.Today.AddDays(2).ToString(), 
            });  
        }
    }
}
