using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentalVideoAPI.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public DateTime BornDate { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }
    }
}