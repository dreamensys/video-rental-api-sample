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
        public string Title { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
        public short Rating { get; set; }
        public int Year { get; set; }
        public ICollection<Customer> Customers { get; set; }
        public Producer Producer { get; set; }
        
    }
}
