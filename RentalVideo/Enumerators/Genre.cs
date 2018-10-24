using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentalVideo.Enumerators
{
    public enum Genre
    {
        Comedy,
        Horror,
        [Display(Name = "Science Fiction")]
        SciFi,
        Romance,
        Documentary,
        Kids
    }
}