using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineShop.Core.Entities;

namespace OnlineShop.Infrastructure.Configurations
{
    class ProductCharacteristicsConfiguration : EntityConfiguration<ProductCharacteristics>
    {
        public override void Configure(EntityTypeBuilder<ProductCharacteristics> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Key)
               .HasMaxLength(50)
               .IsRequired();

            builder.Property(x => x.Value)
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}
