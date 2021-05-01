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
    public class CommentMap : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.UserName).IsRequired();
            builder.Property(t => t.UserName).HasMaxLength(70);
            builder.Property(t => t.UserComment).IsRequired();
            builder.Property(t => t.Date).IsRequired(); 
            builder.ToTable("Comments");
        }
    }
}
