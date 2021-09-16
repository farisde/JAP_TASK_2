using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JAP_TASK_2.Models
{
    public class Top10MoviesByRatingResult
    {
        public int MovieID { get; set; }
        public string MovieTitle { get; set; }
        public int RatingsCount { get; set; }
        public double MovieRating { get; set; }
    }
}
