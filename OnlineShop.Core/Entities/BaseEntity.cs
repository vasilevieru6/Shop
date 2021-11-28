using System;

namespace OnlineShop.Core.Entities
{
    public abstract class BaseEntity 
    {
        public long Id { get; protected set; }

        public DateTime CreatedOn { get; set; }

        public DateTime ModifiedOn { get; set; }
    }
}
