using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoomService.DTOs
{
    public class SeatDTO
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public string Description { get; set; }
    }
}
