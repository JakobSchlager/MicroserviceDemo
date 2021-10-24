using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace RoomDbLib.Entities
{
    public class Seat
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }
        public string Description { get; set; }
    }

    public class SeatEntityTypeConfiguration : IEntityTypeConfiguration<Seat>
    {
        public void Configure(EntityTypeBuilder<Seat> builder)
        {
            builder.ToTable("seat");

            int pK = 1;
            var seats = GenerateSeats(pK, 1, 20);
            builder.HasData(seats);
            pK += seats.Count; 
            seats = GenerateSeats(pK, 2, 40); 
            builder.HasData(seats);
            pK += seats.Count; 
            seats = GenerateSeats(pK, 3, 35); 
            builder.HasData(seats);
            pK += seats.Count; 
            seats = GenerateSeats(pK, 4, 15); 
            builder.HasData(seats);
            pK += seats.Count; 
            seats = GenerateSeats(pK, 5, 40); 
            builder.HasData(seats); 
        }

        private List<Seat> GenerateSeats(int pK,  int roomId, int seatAmount)
        {
            var seats = new List<Seat>(); 
            for (int i = 0; i < seatAmount; i++)
            {
                seats.Add(new Seat
                {
                    RoomId = roomId,
                    Id = pK,
                    Description = "single Seat",
                });
                pK++; 
            }

            return seats; 
        }
    }
}
