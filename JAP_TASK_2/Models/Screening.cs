using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JAP_TASK_2.Models
{
    public class Screening
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        //duration is in minutes
        public float Duration { get; set; }
        public int AvailableSeats { get; set; }
        public int ReservedSeats { get; set; }
        public List<Ticket> Tickets { get; set; }
        public Movie Movie { get; set; }
        public int MovieId { get; set; }
    }
}
