using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieTime.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTime.DataAccess.Concrete.Mappings
{
    public class MovieMap : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Title).IsRequired();
            builder.Property(m => m.Title).HasMaxLength(70);
            builder.Property(m => m.Actors).HasMaxLength(250);
            builder.Property(m => m.Imdb).IsRequired();
            builder.Property(m => m.Director).HasMaxLength(70);
            builder.Property(m => m.Description).HasMaxLength(5000);
            builder.Property(m => m.CreationDate).IsRequired();
            builder.Property(m => m.Thumbnail).IsRequired();
            builder.Property(m => m.Date).IsRequired();
            builder.ToTable("Movies");           
        }
    }
}
