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
    class AddRatingTests
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
                IsMovie = true
            };
            var ratings = new List<Rating>
            {
                new Rating { Id = 1, Value = 5, RatedMovieId = m1.Id },
                new Rating { Id = 2, Value = 4, RatedMovieId = m1.Id },
                new Rating { Id = 3, Value = 3, RatedMovieId = m1.Id },
                new Rating { Id = 4, Value = 2, RatedMovieId = m1.Id },
                new Rating { Id = 5, Value = 1, RatedMovieId = m1.Id },
                new Rating { Id = 6, Value = 5, RatedMovieId = m1.Id },
                new Rating { Id = 7, Value = 4, RatedMovieId = m1.Id },
                new Rating { Id = 8, Value = 3, RatedMovieId = m1.Id },
                new Rating { Id = 9, Value = 2, RatedMovieId = m1.Id },
                new Rating { Id = 10, Value = 1, RatedMovieId = m1.Id }
            };

            var m2 = new Movie
            {
                Id = 2,
                Title = "Star Wars: The Empire Strikes Back (Episode V)",
                Description = "Darth Vader is adamant about turning Luke Skywalker to the dark side. Master Yoda trains Luke to become a Jedi Knight while his friends try to fend off the Imperial fleet.",
                ReleaseDate = new DateTime(1980, 5, 21),
                CoverImage = "https://images.penguinrandomhouse.com/cover/9780345320223",
                IsMovie = true
            };

            m1.RatingList = ratings;
            _context.Movies.Add(m1);
            _context.Movies.Add(m2);
            await _context.SaveChangesAsync();
            #endregion
        }

        [TearDown]
        public async Task TearDown()
        {
            await _context.Database.EnsureDeletedAsync();
        }

        [Test]
        public async Task AddNewRating_NewRatingInfo_SuccessfullyAddedRating()
        {
            var newRating = new AddRatingDto
            {
                RatedMovieId = 1,
                Value = 4
            };

            var response = await _movieService.AddMovieRating(newRating);
            var updatedMovie = response.Data.FirstOrDefault(m => m.Id == 1);

            Assert.Multiple(() =>
            {
                Assert.That(updatedMovie.RatingList.Count, Is.EqualTo(11));
                Assert.That(updatedMovie.RatingList[10].Value, Is.EqualTo(4));
            });
        }

        [Test]
        public async Task AddNewRating_NewRatingInfo_InvalidMovieID()
        {
            var newRating = new AddRatingDto
            {
                RatedMovieId = 100,
                Value = 4
            };

            var response = await _movieService.AddMovieRating(newRating);

            Assert.Multiple(() =>
            {
                Assert.That(response.Success, Is.False);
                Assert.That(response.Message, Is.EqualTo("Selected movie ID doesn't exist."));
                Assert.That(response.Data, Is.Null);
            });
        }
    }
}
