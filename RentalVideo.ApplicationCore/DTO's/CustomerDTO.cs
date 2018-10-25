﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalVideo.ApplicationCore.DTO_s
{
    public class CustomerDTO
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }

        public DateTime Birthday { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public ICollection<MovieDTO> Movies { get; set; }
    }
}
