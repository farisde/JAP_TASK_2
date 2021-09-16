using JAP_TASK_2.DTOs.Reporting;
using JAP_TASK_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JAP_TASK_2.Services.ReportingService
{
    public interface IReportingService
    {
        Task<ServiceResponse<List<Top10MoviesByRatingResult>>> Top10MoviesByRating();
        Task<ServiceResponse<List<Top10MoviesByScreeningsForPeriodResult>>> Top10MoviesByScreeningsForPeriod(SendScreeningPeriodDto screeningPeriod);
        Task<ServiceResponse<List<MostSoldMoviesWithoutRatingsResult>>> MostSoldMoviesWithoutRatings();
    }
}
