using RoomDbLib;
using RoomService.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoomService.Services
{
    public class SeatService
    {
        private readonly RoomDbContext _roomDb;

        public SeatService(RoomDbContext roomDb)
        {
            this._roomDb = roomDb;
        }

        public List<SeatDTO> GetSeats()
        {
            return _roomDb.Seats.Select(x => new SeatDTO
            {
                Id = x.Id,
                Description = x.Description,
                RoomId = x.RoomId
            }).ToList();
        }

        public SeatDTO GetSeat(int id)
        {
            var seat = _roomDb.Seats.Single(x => x.Id == id);
            return new SeatDTO { Id = seat.Id, Description = seat.Description, RoomId = seat.RoomId };
        }
    }
}
