using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoomService.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoomService.Controllers
{
    [Route("api/rooms")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly Services.RoomService _roomService;

        public RoomController(Services.RoomService roomSerives)
        {
            this._roomService = roomSerives;
        }

        [HttpGet]
        public ActionResult<List<RoomDto>> GetAll()
        {
            return Ok(_roomService.GetRooms());
        }

        [HttpGet("{id}")]
        public ActionResult<RoomDto> Get(int id)
        {
            return Ok(_roomService.GetRoom(id));
        }

        [HttpPost]
        public ActionResult<RoomDto> PostRoom([FromBody] RoomDto roomDto)
        {
            return Ok(_roomService.AddRoom(roomDto)); 
        }

        [HttpPost("{id}")]
        public ActionResult<RoomDto> PostSeat(int id, [FromBody] SeatDto seatDto)
        {
           return Ok(_roomService.AddSeat(id, seatDto)); 
        }
    }
}
