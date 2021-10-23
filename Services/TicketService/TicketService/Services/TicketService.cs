using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketDbLib;
using TicketDbLib.Entities;
using TicketService.DTOs;

namespace TicketService.Services
{
    public class TicketService
    {
        private readonly TicketDbContext _ticketDbContext;

        public TicketService(TicketDbContext ticketDbContext)
        {
            this._ticketDbContext = ticketDbContext;
        }

        public List<TicketDto> GetAll()
        {
            return _ticketDbContext.Tickets.Select(x => new TicketDto
            {
                Id = x.Id,
                SeatId = x.SeatId,
                PresentationId = x.PresentationId,
                CustomerName = x.CustomerName,
            })
            .ToList();
        }

        public TicketDto AddTicket(TicketDto ticketDto)
        {
            if (!IsSeatAvailable(ticketDto.PresentationId, ticketDto.SeatId)) throw new Exception("Seat is already taken!");

            var ticket = _ticketDbContext.Tickets.Add(new Ticket
            {
                Id = 0,
                SeatId = ticketDto.SeatId,
                PresentationId = ticketDto.PresentationId,
                CustomerName = ticketDto.CustomerName,
            }).Entity;

            _ticketDbContext.SaveChanges();

            return new TicketDto
            {
                Id = ticket.Id,
                SeatId = ticket.SeatId,
                PresentationId = ticket.PresentationId,
                CustomerName = ticket.CustomerName,
            };
        }

        public TicketDto UpdateTicket(int id, TicketDto ticketDto)
        {
            if (!IsSeatAvailable(ticketDto.PresentationId, ticketDto.SeatId)) throw new Exception("Seat is already taken!");

            var ticketToUpdate = _ticketDbContext.Tickets.Find(id);

            ticketToUpdate.SeatId = ticketDto.SeatId;
            ticketToUpdate.PresentationId = ticketDto.PresentationId;
            ticketToUpdate.CustomerName = ticketDto.CustomerName;

            _ticketDbContext.SaveChanges();

            return new TicketDto
            {
                Id = ticketToUpdate.Id,
                SeatId = ticketToUpdate.SeatId,
                PresentationId = ticketToUpdate.PresentationId,
                CustomerName = ticketToUpdate.CustomerName,
            };
        }

        private bool IsSeatAvailable(int presentationId, int seatId) => 
            _ticketDbContext.Tickets.All(x => !(x.PresentationId == presentationId && x.SeatId == seatId)); 
    }
}
