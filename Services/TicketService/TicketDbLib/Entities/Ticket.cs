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
        }
    }
}
