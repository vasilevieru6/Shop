using System;
using System.Collections.Generic;

namespace OnlineShop.Core.Entities
{
    public class ShoppingCart : BaseEntity
    {
        public DateTime CreatedAt { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public ICollection<ShoppingCartItem> CartItems { get; set; }
    }
}
