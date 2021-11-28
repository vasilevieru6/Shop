using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineShop.Core.Entities;

namespace OnlineShop.Infrastructure.Configurations
{
    class FavoriteItemConfiguration : EntityConfiguration<FavoriteItem>
    {
        public override void Configure(EntityTypeBuilder<FavoriteItem> builder)
        {
            base.Configure(builder);

            builder.HasOne(s => s.Product)
                .WithOne()
                .HasForeignKey<FavoriteItem>(s => s.ProductId);
        }
    }
}
