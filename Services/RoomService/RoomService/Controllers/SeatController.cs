using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoomService.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoomService.Controllers
{
    [Route("api/seats")]
    [ApiController]
    public class SeatController : ControllerBase
    {
        private readonly Services.SeatService _seatService;

        public SeatController(Services.SeatService seatService)
        {
            this._seatService = seatService;
        }

        [HttpGet]
        public ActionResult<List<SeatDto>> GetAll()
        {
            return Ok(_seatService.GetSeats());
        }

        [HttpGet("{id}")]
        public ActionResult<SeatDto> GetSingle(int id)
        {
            return Ok(_seatService.GetSeat(id));
        }
    }
}
