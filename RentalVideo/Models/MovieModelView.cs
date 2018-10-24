using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using RentalVideo.Enumerators;
using Languages;

namespace RentalVideo.Models
{
    public class MovieModelView
    {
        
        public int Id { get; set; }

        [Required]
        [Display(Name = "MOVIE_TITLE", ResourceType = typeof(Resource))]
        public string Title { get; set; }

        [Required]
        [Display(Name = "MOVIE_DESCRIPTION", ResourceType = typeof(Resource))]
        public string Description { get; set; }

        [Required]
        [Display(Name = "MOVIE_GENRE", ResourceType = typeof(Resource))]
        public Genre Genre { get; set; }

    }

    
    
}