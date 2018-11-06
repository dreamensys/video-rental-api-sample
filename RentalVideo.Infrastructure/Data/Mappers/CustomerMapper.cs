
using RentalVideo.ApplicationCore.Entities;
using System.Data.Entity.ModelConfiguration;

namespace RentalVideo.Infrastructure.Data.Mappers
{
    public class CustomerMapper : EntityTypeConfiguration<Customer>
    {
        public CustomerMapper()
        {
            HasKey(s => s.Id);
            Property(s => s.FirstName).HasMaxLength(150);
            Property(s => s.LastName).HasMaxLength(150);
            Property(s => s.Address).HasMaxLength(255);
            Property(s => s.Password).IsRequired();
            Property(s => s.Email).IsRequired();
            HasMany(s => s.Movies);
        }
    }
}
