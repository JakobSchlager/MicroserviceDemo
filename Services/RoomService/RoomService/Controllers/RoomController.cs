using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoomService.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoomService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly Services.RoomService _roomService;

        public RoomController(Services.RoomService roomSerives)
        {
            this._roomService = roomSerives;
        }

        [HttpGet]
        public ActionResult<List<RoomDTO>> GetAll()
        {
            return Ok(_roomService.GetRooms());
        }

        [HttpGet("{id}")]
        public ActionResult<RoomDTO> GetSingle(int id)
        {
            return Ok(_roomService.GetRoom(id));
        }
    }
}
