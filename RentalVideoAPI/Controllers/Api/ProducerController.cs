using RentalVideo.ApplicationCore.Entities;
using RentalVideo.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RentalVideoAPI.Controllers.Api
{
    public class ProducerController : ApiController
    {
        ProducersRepository producersRepo = new ProducersRepository();

        // GET producers
        public IEnumerable<Producer> GetAllProducers()
        {
            var list = producersRepo.GetAllProducers();
            return list;
        }
    }
}
