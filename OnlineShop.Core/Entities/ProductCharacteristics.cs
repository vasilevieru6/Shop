using System.Collections.Generic;

namespace OnlineShop.Core.Entities
{
    public class ProductCharacteristics : BaseEntity
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
