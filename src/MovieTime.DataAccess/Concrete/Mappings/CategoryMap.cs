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
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Name).IsRequired();
            builder.Property(m => m.Name).HasMaxLength(70);
            builder.Property(m => m.Description).HasMaxLength(5000);
            builder.Property(m => m.CreationDate).IsRequired();
            builder.ToTable("Categories");
            builder.HasData(new Category
            {
                CreationDate = DateTime.Now,
                Id = Guid.NewGuid(),
                Name = "Yabancı",
                Description = "Yabancı Filmler"
            },
           new Category
           {
               CreationDate = DateTime.Now,
               Id = Guid.NewGuid(),
               Name = "4K",
               Description = "4K Filmler"
           }
           );
        }
    }
}
