using AutoMapper;
using JAP_TASK_2.DTOs.Movie;
using JAP_TASK_2.DTOs.Screening;
using JAP_TASK_2.Models;

namespace JAP_TASK_2
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Movie, GetMovieDto>();
            CreateMap<CastMember, GetCastMemberDto>();
            CreateMap<Rating, GetRatingDto>();
            CreateMap<AddRatingDto, Rating>();
            CreateMap<Screening, GetScreeningDto>();
            CreateMap<Ticket, GetTicketDto>();
        }
    }
}