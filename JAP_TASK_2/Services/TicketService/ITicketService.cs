using JAP_TASK_2.DTOs.Screening;
using JAP_TASK_2.DTOs.Ticket;
using JAP_TASK_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JAP_TASK_2.Services.TicketService
{
    public interface ITicketService
    {
        Task<ServiceResponse<GetScreeningDto>> BuyTicketsForScreening(BuyTicketDto buyTicket);
    }
}
