using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalVideo.ApplicationCore.Entities
{
    public class Producer
    {
        public int Id { get; set; }

        [MaxLength(150)]
        public string CompanyName { get; set; }

        [MaxLength(100)]
        public string Country { get; set; }
    }
}
