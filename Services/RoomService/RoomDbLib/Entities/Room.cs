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

            builder.HasData(new Room
            {
                Id = 1, 
                Description = "Display: 3D, UHD", 
            });
            builder.HasData(new Room
            {
                Id = 2,
                Description = "Display: 3D", 
            }); 
            builder.HasData(new Room
            {
                Id = 3, 
                Description = "Display: 3D, UHD", 
            }); 
            builder.HasData(new Room
            {
                Id = 4, 
                Description = "Display: 3D, UHD", 
            }); 
            builder.HasData(new Room
            {
                Id = 5, 
                Description = "Display: 4D", 
            }); 
        }
    }
}
