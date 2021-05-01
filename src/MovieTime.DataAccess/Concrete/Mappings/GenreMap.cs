﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieTime.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTime.DataAccess.Concrete.Mappings
{
    public class GenreMap : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Name).IsRequired();
            builder.Property(m => m.Name).HasMaxLength(70);
            builder.Property(m => m.Description).HasMaxLength(5000);
            builder.Property(m => m.CreationDate).IsRequired();
            builder.ToTable("Genres");

            builder.HasData(new Genre
            {
                CreationDate = DateTime.Now,
                Id = Guid.NewGuid(),
                Name = "Aile",
                Description = "Aile Filmleri"
            },
           new Genre
           {
               CreationDate = DateTime.Now,
               Id = Guid.NewGuid(),
               Name = "Fantastik",
               Description = "Fantastik Filmler"
           }
           );
        }
    }
}
