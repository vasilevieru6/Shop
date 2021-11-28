using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineShop.Core.Entities;

namespace OnlineShop.Infrastructure.Configurations
{
    class ShoppingCartConfiguration : EntityConfiguration<ShoppingCart>
    {
        public override void Configure(EntityTypeBuilder<ShoppingCart> builder)
        {
            base.Configure(builder);

            builder
                 .HasOne(x => x.User)
                 .WithOne(x => x.ShoppingCart)
                 .HasForeignKey<ShoppingCart>(x => x.UserId);
        }
    }
}
