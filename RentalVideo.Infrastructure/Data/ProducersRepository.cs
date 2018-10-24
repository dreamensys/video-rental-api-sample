using RentalVideo.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalVideo.Infrastructure.Data
{
    public class ProducersRepository : Repository
    {
        public IEnumerable<Producer> GetAllProducers()
        {
            return context.Producers.ToList();
        }
    }
}
