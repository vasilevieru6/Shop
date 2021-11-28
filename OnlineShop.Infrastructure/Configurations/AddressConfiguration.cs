using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineShop.Core.Entities;

namespace OnlineShop.Infrastructure.Configurations
{
    class AddressConfiguration : EntityConfiguration<Address>
    {
        public override void Configure(EntityTypeBuilder<Address> builder)
        {
            base.Configure(builder);

            builder.Property(a => a.City)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(a => a.Country)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(a => a.Street)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(a => a.PostalCode)
                .HasMaxLength(20)
                .IsRequired();
        }
    }
}
