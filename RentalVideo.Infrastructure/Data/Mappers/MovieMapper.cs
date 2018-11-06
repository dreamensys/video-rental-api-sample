
using RentalVideo.ApplicationCore.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;

namespace RentalVideo.Infrastructure.Data.Mappers
{
    public class MovieMapper : EntityTypeConfiguration<Movie>
    {
        public MovieMapper()
        {
            HasKey(s => s.Id);
            Property(s => s.Title).IsRequired();
            Property(s => s.Title).HasMaxLength(150);
            Property(s => s.Description).IsRequired();
            Property(s => s.Description).HasMaxLength(150);
            Property(s => s.Duration).IsRequired();
            HasRequired(s => s.Producer);
            HasMany(s => s.Customers);
        }
    }
}
