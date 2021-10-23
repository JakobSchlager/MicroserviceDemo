using RoomDbLib;
using RoomDbLib.Entities;
using RoomService.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoomService.Services
{
    public class RoomService
    {
        private readonly RoomDbContext _roomDb;

        public RoomService(RoomDbContext roomDb)
        {
            this._roomDb = roomDb;
        }

        public List<RoomDto> GetRooms()
        {
            return _roomDb.Rooms.Select(x => new RoomDto
            {
                Id = x.Id,
                Description = x.Description,
            }).ToList();
        }

        public RoomDto GetRoom(int id)
        {
            var room =  _roomDb.Rooms.Single(x => x.Id == id);
            return new RoomDto { Id = room.Id, Description = room.Description };
        }

        public RoomDto AddRoom(RoomDto roomDto)
        {
            var room = _roomDb.Rooms.Add(new Room
            {
                Id = 0,
                Description = roomDto.Description, 
            }).Entity;

            _roomDb.SaveChanges();

            return new RoomDto
            {
                Id = room.Id,
                Description = room.Description,
            }; 
        }

        public SeatDto AddSeat(int id, SeatDto seatDto)
        {
            if (_roomDb.Rooms.Find(id) == null) throw new Exception($"Room with id: {id} does not exist!"); 

            var seat = _roomDb.Seats.Add(new Seat {
                Id = 0,
                Description = seatDto.Description,
                RoomId = seatDto.RoomId,
            }).Entity;

            _roomDb.SaveChanges(); 

            return new SeatDto
            {
                Id = seat.Id, 
                RoomId = seat.RoomId, 
                Description = seat.Description,
            }; 
        }
    }
}
