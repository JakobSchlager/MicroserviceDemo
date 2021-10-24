using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketDbLib.Entities
{
    public class Ticket
    {
        public int Id { get; set; }
        public int PresentationId { get; set; }
        public int SeatId { get; set; }
        public string CustomerName { get; set; }
    }

    public class TicketEntityTypeConfiguration : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.ToTable("ticket");

            builder.HasData(new Ticket
            {
                Id = 1,
                PresentationId = 1,
                CustomerName = "Jakob Schlager",
                SeatId = 15,
            });
            builder.HasData(new Ticket
            {
                Id = 2,
                PresentationId = 1,
                CustomerName = "Thomas Wahlmüller",
                SeatId = 18,
            });
            builder.HasData(new Ticket
            {
                Id = 3,
                PresentationId = 2,
                CustomerName = "Florian Auer",
                SeatId = 30,
            });
            builder.HasData(new Ticket
            {
                Id = 4,
                PresentationId = 2,
                CustomerName = "Fabian Graml",
                SeatId = 31,
            });
        }
    }
}
