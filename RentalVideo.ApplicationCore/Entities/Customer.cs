using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalVideo.ApplicationCore.Entities
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(150),MinLength(5)]
        public string FirstName {get; set;}

        [MaxLength(150), MinLength(5)]
        public string LastName {get; set;}

        [MaxLength(255), MinLength(10)]
        public string Address {get; set;}
        
        public DateTime Birthday {get; set;}

        [Required]
        public string Password {get; set;}

        [Required]
        public string Email {get; set;}

        public ICollection<Movie> Movies { get; set; }
    }
}
