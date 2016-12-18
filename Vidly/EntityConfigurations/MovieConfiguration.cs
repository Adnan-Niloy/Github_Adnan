using System.Data.Entity.ModelConfiguration;
using Vidly.Models;

namespace Vidly.EntityConfigurations
{
    public class MovieConfiguration : EntityTypeConfiguration<Movie>
    {
        public MovieConfiguration()
        {
            Property(m => m.Name)
                .HasMaxLength(255)
                .IsRequired();

            Property(m => m.GenreId)
                .IsRequired();

            Property(m => m.NumberInStock)
                .IsRequired();
        }
    }
}