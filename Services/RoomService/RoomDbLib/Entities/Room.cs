using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RoomDbLib.Entities
{
    public class Room
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }

    public class RoomEntityTypeConfiguration : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.ToTable("room");
        }
    }
}
