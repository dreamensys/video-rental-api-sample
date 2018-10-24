using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalVideo.Infrastructure.Data
{
    public abstract class Repository
    {
        public ManagerDbContext context = new ManagerDbContext();
    }
}
