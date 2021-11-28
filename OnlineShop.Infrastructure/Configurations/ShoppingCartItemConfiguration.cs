using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineShop.Core.Entities;

namespace OnlineShop.Infrastructure.Configurations
{
    class ShoppingCartItemConfiguration : EntityConfiguration<ShoppingCartItem>
    {
        public override void Configure(EntityTypeBuilder<ShoppingCartItem> builder)
        {
            base.Configure(builder);

            builder.HasOne(s => s.Product)
                .WithOne()
                .HasForeignKey<ShoppingCartItem>(s => s.ProductId);
        }
    }
}
