using AutoMapper;
using JAP_TASK_2.Data;
using JAP_TASK_2.DTOs.Screening;
using JAP_TASK_2.DTOs.Ticket;
using JAP_TASK_2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace JAP_TASK_2.Services.TicketService
{
    public class TicketService : ITicketService
    {
        private readonly DataContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMapper _mapper;

        public TicketService(DataContext context, IHttpContextAccessor httpContextAccessor, IMapper mapper)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
        }

        private int GetUserId() => int.Parse(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));

        public async Task<ServiceResponse<GetScreeningDto>> BuyTicketsForScreening(BuyTicketDto buyTicket)
        {
            var response = new ServiceResponse<GetScreeningDto>();

            if (buyTicket.TicketAmount <= 0)
            {
                response.Success = false;
                response.Message = "Ticket amount needs to be greater than zero.";
                return response;
            }

            var screening = await _context.Screenings
                                          .Include(s => s.Tickets)
                                          .FirstOrDefaultAsync(s => s.Id == buyTicket.ScreeningID);

            if (screening == null)
            {
                response.Success = false;
                response.Message = "Selected screening doesn't exist.";
                return response;
            }

            if (screening.StartTime < DateTime.Now)
            {
                response.Success = false;
                response.Message = "The selected screening is not available anymore.";
                return response;
            }

            if (screening.AvailableSeats < screening.ReservedSeats + buyTicket.TicketAmount)
            {
                response.Success = false;
                response.Message = "There are not enough available seats for the requested number of tickets.";
                return response;
            }

            screening.ReservedSeats += buyTicket.TicketAmount;
            for (int i = 0; i < buyTicket.TicketAmount; i++)
            {
                screening.Tickets.Add(new Ticket
                {
                    Price = buyTicket.TicketPrice,
                    ScreeningId = screening.Id,
                    UserId = GetUserId()
                });
            }
            _context.Screenings.Update(screening);
            await _context.SaveChangesAsync();

            response.Data = _mapper.Map<GetScreeningDto>(screening);
            response.Data.TotalPrice = buyTicket.TicketAmount * buyTicket.TicketPrice;

            return response;
        }
    }
}
