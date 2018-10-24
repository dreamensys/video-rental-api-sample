using RentalVideo.ActionFilters;
using RentalVideo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentalVideo.Repository
{
    
    public class MovieRepository
    {
        public static MovieRepository instance; 
        private List<MovieModelView> moviesList = new List<MovieModelView>();
        public MovieRepository()
        {
            moviesList = new List<MovieModelView>();
            moviesList.Add(new MovieModelView()
            {
                Id = 1,
                Title = "Life of Pi",
                Description = "Awesome",
                Genre = Enumerators.Genre.SciFi
            });
            moviesList.Add(new MovieModelView()
            {
                Id = 2,
                Title = "La Monja",
                Description = "Scary",
                Genre = Enumerators.Genre.Horror
            });
            moviesList.Add(new MovieModelView()
            {
                Id = 3,
                Title = "Coco",
                Description = "Awww",
                Genre = Enumerators.Genre.Kids
            });
        }
        
       
        public List<MovieModelView> GetAllMovies()
        {
            return moviesList;
        }
        public void AddMovie(MovieModelView model)
        {
            int max = moviesList.Max(i => i.Id);
            model.Id = max + 1;
            moviesList.Add(model);
        }
        // This is a singleton in order to give just one instance of my fake DB
        public static MovieRepository GetInstance()
        {
            if (instance == null)
            {
                instance = new MovieRepository();
            }
            return instance;
        }

        public void Updatemovie(MovieModelView model)
        {
            var foundModel = moviesList.FirstOrDefault(u => u.Id == model.Id);
            foundModel.Description = model.Description;
            foundModel.Title = model.Title;
            foundModel.Genre = model.Genre;
            moviesList.RemoveAll(r => r.Id == model.Id);
            moviesList.Add(foundModel);
        }

        public void DeleteMovie(int id)
        {
            moviesList.RemoveAll(a => a.Id == id);
        }
        public MovieModelView GetMovieById(int id)
        {
            return moviesList.FirstOrDefault(u => u.Id == id);
        }
    }
}