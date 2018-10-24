using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers.Api
{
    public class MovieModelView
    {

        public int Id { get; set; }
        
        public string Title { get; set; }
        
        public string Description { get; set; }
        

    }
    public class MoviesController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<MovieModelView> GetMovies()
        {
            List<MovieModelView> list = new List<MovieModelView>();
            list.Add(new MovieModelView()
            {
                Id = 1,
                Title = "Matrix",
                Description = "Science Fiction"
            });
            list.Add(new MovieModelView()
            {
                Id = 2,
                Title = "The Shining",
                Description = "Horror"
            });
            return list;
        }
    }
}
