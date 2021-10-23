using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketService.DTOs
{
    public class TicketDto
    {
        public int Id { get; set; }
        public int PresentationId { get; set; }
        public int SeatId { get; set; }
        public string CustomerName { get; set; }
    }
}
