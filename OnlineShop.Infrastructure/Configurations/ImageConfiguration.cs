using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineShop.Core.Entities;

namespace OnlineShop.Infrastructure.Configurations
{
    class ImageConfiguration : EntityConfiguration<Image>
    {
        public override void Configure(EntityTypeBuilder<Image> builder)
        {
            base.Configure(builder);

            builder.Property(f => f.Name)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(f => f.MimeType)
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(f => f.Path)
                .HasMaxLength(200)
                .IsRequired();

            builder.HasIndex(f => f.Path)
                .IsUnique();
        }
    }
}
