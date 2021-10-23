using RoomDbLib;
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

        public List<RoomDTO> GetRooms()
        {
            return _roomDb.Rooms.Select(x => new RoomDTO
            {
                Id = x.Id,
                Description = x.Description,
            }).ToList();
        }

        public RoomDTO GetRoom(int id)
        {
            var room =  _roomDb.Rooms.Single(x => x.Id == id);
            return new RoomDTO { Id = room.Id, Description = room.Description };
        }

    }
}
