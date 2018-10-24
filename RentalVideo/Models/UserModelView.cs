using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Languages;

namespace RentalVideo.Models
{
    public class UserModelView
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "USER_NAME", ResourceType = typeof(Resource))]
        public string Name { get; set; }

        [Required] 
        [EmailAddress] 
        [Display(Name = "USER_EMAIL", ResourceType = typeof(Resource))]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Contraseñas no coinciden")]
        public string ConfirmPassword { get; set; }

        public string Language { get; set; }
    }
}