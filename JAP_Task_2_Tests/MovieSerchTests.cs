using AutoMapper;
using JAP_TASK_2.Data;
using JAP_TASK_2.DTOs.Movie;
using JAP_TASK_2.Models;
using JAP_TASK_2.Services.MovieService;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP_TASK_2
{
    [TestFixture]
    class MovieSerchTests
    {
        private DataContext _context;
        private IMovieService _movieService;
        private IMapper _mapper;

        [SetUp]
        public async Task Setup()
        {
            #region InitializeDbContext
            var options = new DbContextOptionsBuilder<DataContext>()
                .UseInMemoryDatabase(databaseName: "movie_temp").Options;

            _context = new DataContext(options);
            #endregion

            #region InitializeMovieService
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapperProfile());
            });
            _mapper = mapperConfig.CreateMapper();

            _movieService = new MovieService(_context, _mapper);
            #endregion

            #region AddDataToDb
            var m1 = new Movie
            {
                Id = 1,
                Title = "Star Wars: A New Hope (Episode IV)",
                Description = "After Princess Leia, the leader of the Rebel Alliance, is held hostage by Darth Vader, Luke and Han Solo must free her and destroy the powerful weapon created by the Galactic Empire.",
                ReleaseDate = new DateTime(1997, 5, 25),
                CoverImage = "https://kbimages1-a.akamaihd.net/538b1473-6d45-47f4-b16e-32a0a6ba7f9a/1200/1200/False/star-wars-episode-iv-a-new-hope-3.jpg",
                Rating = 3,
                IsMovie = true,
                Cast = new List<CastMember>
                {
                    new CastMember { Id = 1, Name = "Carrie Fisher" },
                    new CastMember { Id = 2, Name = "Mark Hamil" }
                }
            };

            var m2 = new Movie
            {
                Id = 2,
                Title = "Star Wars: The Empire Strikes Back (Episode V)",
                Description = "Darth Vader is adamant about turning Luke Skywalker to the dark side. Master Yoda trains Luke to become a Jedi Knight while his friends try to fend off the Imperial fleet.",
                ReleaseDate = new DateTime(1980, 5, 21),
                CoverImage = "https://images.penguinrandomhouse.com/cover/9780345320223",
                Rating = 2,
                IsMovie = true
            };

            var m3 = new Movie
            {
                Id = 3,
                Title = "Riverdale",
                Description = "Archie, Betty, Jughead and Veronica tackle being teenagers in a town that is rife with sinister happenings and blood-thirsty criminals.",
                ReleaseDate = new DateTime(2017, 1, 26),
                CoverImage = "https://static.wikia.nocookie.net/riverdalearchie/images/3/3a/Season_2_Poster.jpg",
                Rating = 4.5,
                IsMovie = false
            };

            var m4 = new Movie
            {
                Id = 4,
                Title = "The Blacklist",
                Description = "A wanted fugitive mysteriously surrenders himself to the FBI and offers to help them capture deadly criminals. His sole condition is that he will work only with the new profiler, Elizabeth Keen.",
                ReleaseDate = new DateTime(2013, 9, 23),
                CoverImage = "https://static.wikia.nocookie.net/blacklist/images/5/57/Season_7_Poster.jpg",
                Rating = 5,
                IsMovie = false
            };


            var ratings = new List<Rating>
            {
                new Rating { Id = 1, Value = 5, RatedMovieId = m1.Id },
                new Rating { Id = 2, Value = 4, RatedMovieId = m1.Id },
                new Rating { Id = 3, Value = 3, RatedMovieId = m1.Id },
                new Rating { Id = 4, Value = 2, RatedMovieId = m1.Id },
                new Rating { Id = 5, Value = 1, RatedMovieId = m1.Id }
            };

            var r2 = new Rating { Id = 8, Value = 2, RatedMovieId = m2.Id };
            var r3 = new Rating { Id = 6, Value = 4.5, RatedMovieId = m3.Id };
            var r4 = new Rating { Id = 7, Value = 5, RatedMovieId = m4.Id };

            m1.RatingList = ratings;
            m2.RatingList = new List<Rating> { r2 };
            m3.RatingList = new List<Rating> { r3 };
            m4.RatingList = new List<Rating> { r4 };
            _context.Movies.Add(m1);
            _context.Movies.Add(m2);
            _context.Movies.Add(m3);
            _context.Movies.Add(m4);
            await _context.SaveChangesAsync();
            #endregion
        }

        [TearDown]
        public async Task TearDown()
        {
            await _context.Database.EnsureDeletedAsync();
        }

        [Test]
        public async Task MovieShowSearch_InputSearchQuery_5StarContent()
        {
            var query = new SendSearchResultsDto
            {
                SearchPhrase = "5 stars"
            };

            var response = await _movieService.GetSearchResults(query);

            Assert.Multiple(() =>
            {
                Assert.That(response.Success, Is.True);
                Assert.That(response.Data.Count, Is.EqualTo(1));
            });
        }

        [Test]
        public async Task MovieShowSearch_InputSearchQuery_AtLeast3StarContent()
        {
            var query = new SendSearchResultsDto
            {
                SearchPhrase = "at least 3 stars"
            };

            var response = await _movieService.GetSearchResults(query);

            Assert.Multiple(() =>
            {
                Assert.That(response.Success, Is.True);
                Assert.That(response.Data.Count, Is.EqualTo(3));
            });
        }

        [Test]
        public async Task MovieShowSearch_InputSearchQuery_After2015Content()
        {
            var query = new SendSearchResultsDto
            {
                SearchPhrase = "after 2015"
            };

            var response = await _movieService.GetSearchResults(query);

            Assert.Multiple(() =>
            {
                Assert.That(response.Success, Is.True);
                Assert.That(response.Data.Count, Is.EqualTo(1));
            });
        }

        [Test]
        public async Task MovieShowSearch_InputSearchQuery_OlderThan5YearsContent()
        {
            var query = new SendSearchResultsDto
            {
                SearchPhrase = "older than 5 years"
            };

            var response = await _movieService.GetSearchResults(query);

            Assert.Multiple(() =>
            {
                Assert.That(response.Success, Is.True);
                Assert.That(response.Data.Count, Is.EqualTo(3));
            });
        }

        [Test]
        public async Task MovieShowSearch_InputSearchQuery_ContentWithDescriptionMatch()
        {
            var query = new SendSearchResultsDto
            {
                SearchPhrase = "Betty"
            };

            var response = await _movieService.GetSearchResults(query);

            Assert.Multiple(() =>
            {
                Assert.That(response.Success, Is.True);
                Assert.That(response.Data.Count, Is.EqualTo(1));
            });
        }

        [Test]
        public async Task MovieShowSearch_InputSearchQuery_ContentWithTitleMatch()
        {
            var query = new SendSearchResultsDto
            {
                SearchPhrase = "Star"
            };

            var response = await _movieService.GetSearchResults(query);

            Assert.Multiple(() =>
            {
                Assert.That(response.Success, Is.True);
                Assert.That(response.Data.Count, Is.EqualTo(2));
            });
        }

        [Test]
        public async Task MovieShowSearch_InputSearchQuery_ContentWithCastMemberMatch()
        {
            var query = new SendSearchResultsDto
            {
                SearchPhrase = "Hamil"
            };

            var response = await _movieService.GetSearchResults(query);

            Assert.Multiple(() =>
            {
                Assert.That(response.Success, Is.True);
                Assert.That(response.Data.Count, Is.EqualTo(1));
            });
        }
    }
}
