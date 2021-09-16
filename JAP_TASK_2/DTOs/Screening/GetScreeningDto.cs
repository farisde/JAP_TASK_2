using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JAP_TASK_2.DTOs.Screening
{
    public class GetScreeningDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public float Duration { get; set; }
        public int AvailableSeats { get; set; }
        public int ReservedSeats { get; set; }
        public List<GetTicketDto> Tickets { get; set; }
        public double TotalPrice { get; set; }
    }
}
