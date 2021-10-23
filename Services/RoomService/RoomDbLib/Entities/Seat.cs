using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomDbLib.Entities
{
    public class Seat
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public string Description { get; set; }

        public Room Room { get; set; }
    }
}
