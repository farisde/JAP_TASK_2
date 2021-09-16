using JAP_TASK_2.Data;
using JAP_TASK_2.DTOs.Reporting;
using JAP_TASK_2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JAP_TASK_2.Services.ReportingService
{
    public class ReportingService : IReportingService
    {
        private readonly DataContext _context;

        public ReportingService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<List<MostSoldMoviesWithoutRatingsResult>>> MostSoldMoviesWithoutRatings()
        {
            var response = new ServiceResponse<List<MostSoldMoviesWithoutRatingsResult>>();

            response.Data = await _context.MostSoldMoviesWithoutRatingsResults.FromSqlRaw("EXEC [dbo].[MostSoldMoviesWithoutRatings];")
                                                                              .ToListAsync();

            return response;
        }

        public async Task<ServiceResponse<List<Top10MoviesByRatingResult>>> Top10MoviesByRating()
        {
            var response = new ServiceResponse<List<Top10MoviesByRatingResult>>();

            response.Data = await _context.Top10MoviesByRatingResults.FromSqlRaw("EXEC [dbo].[Top10MoviesByRating];")
                                                                     .ToListAsync();

            return response;
        }

        public async Task<ServiceResponse<List<Top10MoviesByScreeningsForPeriodResult>>> Top10MoviesByScreeningsForPeriod(SendScreeningPeriodDto screeningPeriod)
        {
            var response = new ServiceResponse<List<Top10MoviesByScreeningsForPeriodResult>>();

            response.Data = await _context.Top10MoviesByScreeningsForPeriodResults.FromSqlRaw("EXEC [dbo].[Top10MoviesByScreeningsForPeriod] {0}, {1};", screeningPeriod.StartDate, screeningPeriod.EndDate)
                                                                                  .ToListAsync();

            return response;
        }
    }
}
