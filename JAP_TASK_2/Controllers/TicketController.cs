using JAP_TASK_2.DTOs.Screening;
using JAP_TASK_2.DTOs.Ticket;
using JAP_TASK_2.Models;
using JAP_TASK_2.Services.TicketService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JAP_TASK_2.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class TicketController : ControllerBase
    {
        private readonly ITicketService _ticketService;

        public TicketController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }

        [HttpPost("BuyTickets")]
        public async Task<ActionResult<ServiceResponse<GetScreeningDto>>> BuyTicketsForScreening(BuyTicketDto buyTicket)
        {
            var response = await _ticketService.BuyTicketsForScreening(buyTicket);
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }
    }
}
