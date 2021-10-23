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

        public List<SeatDto> GetSeats()
        {
            return _roomDb.Seats.Select(x => new SeatDto
            {
                Id = x.Id,
                Description = x.Description,
                RoomId = x.RoomId
            }).ToList();
        }

        public SeatDto GetSeat(int id)
        {
            var seat = _roomDb.Seats.Single(x => x.Id == id);
            return new SeatDto { Id = seat.Id, Description = seat.Description, RoomId = seat.RoomId };
        }
    }
}
