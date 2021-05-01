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
    public class TagMap : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Name).IsRequired();
            builder.Property(t => t.Name).HasMaxLength(70);    
            builder.Property(t => t.Description).HasMaxLength(5000);
            builder.Property(t => t.CreationDate).IsRequired();;
            builder.ToTable("Tags");
        }
    }
}
