using RentalVideo.ApplicationCore.Entities;
using RentalVideo.Infrastructure.Data;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;

namespace RentalVideoAPI.Controllers.Api
{

    public class MoviesController : ApiController
    {
        private MoviesRepository moviesRepo = new MoviesRepository();
        // GET api/movies
        public IEnumerable<Movie> GetAllMovies()
        {
            var list = moviesRepo.GetAllMovies();
            return list;
        }

        // GET /api/movies/1
        public Movie GetMovie(int id)
        {
            Movie model = moviesRepo.GetMovieById(id);

            if (model == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return model;
        }

        //// POST /api/movies
        [HttpPost]
        public Movie CreateMovie(Movie movie)
        {
            bool result = moviesRepo.AddMovie(movie);
            if (!result)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            return movie;
        }

        //// PUT /api/movies/id
        [HttpPut]
        public Movie UpdateMovie(int id, Movie movie)
        {
            var model = moviesRepo.Updatemovie(movie);
            if (model == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return model;
        }

        //// DELETE /api/movies/id
        [HttpDelete]
        public bool DeleteMovie(int id)
        {
            bool result = moviesRepo.DeleteMovie(id);
            if (!result)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return true;
        }
    }
}
