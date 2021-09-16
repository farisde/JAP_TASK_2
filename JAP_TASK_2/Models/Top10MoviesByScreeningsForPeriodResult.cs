using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JAP_TASK_2.Models
{
    public class Top10MoviesByScreeningsForPeriodResult
    {
        public int MovieID { get; set; }
        public string MovieTitle { get; set; }
        public int ScreeningsCount { get; set; }
    }
}
