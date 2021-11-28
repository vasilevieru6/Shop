using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Infrastructure.Configurations
{
    class FileDescriptionConfiguration : EntityConfiguration<FileDescription>
    {
        public override void Configure(EntityTypeBuilder<FileDescription> builder)
        {
            base.Configure(builder);

            builder.Property(f => f.FileName)
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(f => f.OriginalName)
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(f => f.FileType)
                .HasMaxLength(11)
                .IsRequired();
        }
    }
}
