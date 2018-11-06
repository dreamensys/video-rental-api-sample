using RentalVideo.ApplicationCore.Entities;
using RentalVideo.Infrastructure.Data.Mappers;
using System.Data.Entity;

namespace RentalVideo.Infrastructure.Data
{
    public class ManagerDbContext : DbContext
    {
        public ManagerDbContext() : base(@"data source=.\SQLEXPRESS; initial catalog=RentalVideoDB; integrated security=SSPI")
        {
        }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Producer> Producers { get; set; }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MovieMapper());
            modelBuilder.Configurations.Add(new CustomerMapper());
            modelBuilder.Configurations.Add(new ProducerMapper());
            
        }
       
        


    }
}
