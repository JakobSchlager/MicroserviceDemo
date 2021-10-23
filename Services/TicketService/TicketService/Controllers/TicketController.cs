using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketService.DTOs;

namespace TicketService.Controllers
{
    [Route("api/tickets")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly Services.TicketService _ticketService;

        public TicketController(Services.TicketService ticketService)
        {
            this._ticketService = ticketService;
        }

        [HttpGet]
        public ActionResult<List<TicketDto>> GetAll()
        {
            return Ok(_ticketService.GetAll());
        }

        [HttpPost]
        public ActionResult<TicketDto> Post([FromBody] TicketDto ticketDto)
        {
            return Ok(_ticketService.AddTicket(ticketDto));
        }

        [HttpPut("{id}")]
        public ActionResult<TicketDto> Put(int id, [FromBody] TicketDto ticketDto)
        {
            return Ok(_ticketService.UpdateTicket(id, ticketDto)); 
        }
    }
}
