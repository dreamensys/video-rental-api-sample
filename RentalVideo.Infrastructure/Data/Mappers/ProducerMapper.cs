
using RentalVideo.ApplicationCore.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;

namespace RentalVideo.Infrastructure.Data.Mappers
{
    public class ProducerMapper : EntityTypeConfiguration<Producer>
    {
        public ProducerMapper()
        {
            HasKey(s => s.Id);
            Property(s => s.CompanyName).HasMaxLength(155);
            Property(s => s.Country).HasMaxLength(155);
        }
    }
}
