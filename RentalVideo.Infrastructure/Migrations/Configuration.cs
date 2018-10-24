namespace RentalVideo.Infrastructure.Migrations
{
    using RentalVideo.ApplicationCore.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RentalVideo.Infrastructure.Data.ManagerDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(RentalVideo.Infrastructure.Data.ManagerDbContext context)
        {
            context.Producers.AddOrUpdate(new Producer() { Id = 1, CompanyName = "Universal", Country = "United States" });
            context.Producers.AddOrUpdate(new Producer() { Id = 2, CompanyName = "FOX", Country = "United States" });
            context.Producers.AddOrUpdate(new Producer() { Id = 3, CompanyName = "Tristar", Country = "United States" });
            context.Producers.AddOrUpdate(new Producer() { Id = 4, CompanyName = "Disney", Country = "United States" });
            context.Producers.AddOrUpdate(new Producer() { Id = 5, CompanyName = "Caracol", Country = "Colombia" });
            //context.SaveChanges();
            base.Seed(context);
        }
    }
}
