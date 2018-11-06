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
        public string CompanyName { get; set; }
        public string Country { get; set; }
    }
}
