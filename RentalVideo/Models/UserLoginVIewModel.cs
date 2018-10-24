using Languages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentalVideo.Models
{
    public class UserLoginVIewModel
    {

        public int Id { get; set; }

        [Display(Name = "USER_NAME", ResourceType = typeof(Resource))]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "USER_EMAIL", ResourceType = typeof(Resource))]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string Language { get; set; }
    }
}