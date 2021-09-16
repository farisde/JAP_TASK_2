using JAP_TASK_2.DTOs.Reporting;
using JAP_TASK_2.Models;
using JAP_TASK_2.Services.ReportingService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JAP_TASK_2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReportingController : ControllerBase
    {
        private readonly IReportingService _reportingService;

        public ReportingController(IReportingService reportingService)
        {
            _reportingService = reportingService;
        }

        [HttpGet("Top10MoviesByRating")]
        public async Task<ActionResult<ServiceResponse<List<Top10MoviesByRatingResult>>>> GetTop10MoviesByRating()
        {
            var response = await _reportingService.Top10MoviesByRating();
            return Ok(response);
        }

        [HttpPost("Top10MoviesByScreeningsForPeriod")]
        public async Task<ActionResult<ServiceResponse<List<Top10MoviesByScreeningsForPeriodResult>>>> Top10MoviesByScreeningsForPeriod(SendScreeningPeriodDto screeningPeriod)
        {
            var response = await _reportingService.Top10MoviesByScreeningsForPeriod(screeningPeriod);
            return Ok(response);
        }

        [HttpGet("MostSoldMoviesWithoutRatings")]
        public async Task<ActionResult<ServiceResponse<List<Top10MoviesByRatingResult>>>> GetMostSoldMoviesWithoutRatings()
        {
            var response = await _reportingService.MostSoldMoviesWithoutRatings();
            return Ok(response);
        }
    }
}
