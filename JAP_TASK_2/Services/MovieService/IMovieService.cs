using System.Collections.Generic;
using System.Threading.Tasks;
using JAP_TASK_2.DTOs.Movie;
using JAP_TASK_2.Models;
using JAP_TASK_2.Queries;

namespace JAP_TASK_2.Services.MovieService
{
    public interface IMovieService
    {
        Task<PagedResponse<List<GetMovieDto>>> GetMovies(int userId, PaginationQuery paginationQuery = null);
        Task<ServiceResponse<List<GetMovieDto>>> AddMovieRating(AddRatingDto newRating);

        Task<ServiceResponse<List<GetMovieDto>>> GetSearchResults(SendSearchResultsDto query);
    }
}