namespace OnlineShop.Core.Entities
{
    public class FavoriteItem : BaseEntity
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
