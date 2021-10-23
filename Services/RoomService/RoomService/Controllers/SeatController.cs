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
    public class SeatController : ControllerBase
    {
        private readonly Services.SeatService _seatService;

        public SeatController(Services.SeatService seatService)
        {
            this._seatService = seatService;
        }

        [HttpGet]
        public ActionResult<List<SeatDTO>> GetAll()
        {
            return Ok(_seatService.GetSeats());
        }

        [HttpGet("{id}")]
        public ActionResult<SeatDTO> GetSingle(int id)
        {
            return Ok(_seatService.GetSeat(id));
        }
    }
}
