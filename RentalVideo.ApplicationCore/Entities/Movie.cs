using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalVideo.ApplicationCore.Entities
{
    public class Movie
    {
        public int Id { get; set; }

        [MaxLength(150), MinLength(5)]
        [Required]
        public string Title { get; set; }

        [MaxLength(255), MinLength(5)]
        [Required]
        public string Description { get; set; }
        [Required]
        public int Duration { get; set; }
        public short Rating { get; set; }

        public int Year { get; set; }
        public ICollection<Customer> Customers { get; set; }
        public Producer Producer { get; set; }
        
    }
}
