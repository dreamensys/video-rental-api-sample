using RentalVideo.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalVideo.Infrastructure.Data
{
    public class MoviesRepository : Repository
    {
        
        public MoviesRepository()
        {

        }


        public List<Movie> GetAllMovies()
        {
            return context.Movies.ToList();
        }
        public bool AddMovie(Movie model)
        {
            try
            {
                context.Movies.Add(model);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }


        public Movie Updatemovie(Movie model)
        {
            var foundModel = context.Movies.FirstOrDefault(u => u.Id == model.Id);
            if (foundModel == null)
            {
                throw new Exception("The movie was not found.");
            }
            foundModel.Description = model.Description;
            foundModel.Title = model.Title;
            context.SaveChanges();
            return foundModel;
        }

        public bool DeleteMovie(int id)
        {
            try
            {
                var foundMovie = context.Movies.SingleOrDefault(v => v.Id == id);
                context.Movies.Remove(foundMovie);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }


        }
        public Movie GetMovieById(int id)
        {
            return context.Movies.SingleOrDefault(v => v.Id == id);
        }
    }
}
