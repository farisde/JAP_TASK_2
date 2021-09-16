using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JAP_TASK_2.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public Screening Screening { get; set; }
        public int ScreeningId { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
    }
}
