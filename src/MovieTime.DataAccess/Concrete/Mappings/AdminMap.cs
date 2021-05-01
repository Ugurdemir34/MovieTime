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
    public class AdminMap : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Name).IsRequired();
            builder.Property(m => m.Name).HasMaxLength(70);
            builder.Property(m => m.Password).IsRequired();
            builder.Property(m => m.Password).HasMaxLength(70);
            builder.Property(m => m.Description).HasMaxLength(5000);
            builder.Property(m => m.CreationDate).IsRequired();
            builder.Property(m => m.UserName).IsRequired();
            builder.Property(m => m.UserName).HasMaxLength(70);
            builder.ToTable("Admins");
        }
    }
}
