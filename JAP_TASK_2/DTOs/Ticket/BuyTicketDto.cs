using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JAP_TASK_2.DTOs.Ticket
{
    public class BuyTicketDto
    {
        public int ScreeningID { get; set; }
        public int TicketAmount { get; set; }
        public double TicketPrice { get; set; }
    }
}
