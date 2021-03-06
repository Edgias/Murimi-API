using Murimi.ApplicationCore.SharedKernel;
using System;

namespace Murimi.ApplicationCore.Entities
{
    public class Item : BaseEntity, IAggregateRoot
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public Guid ItemCategoryId { get; set; }

        public ItemCategory ItemCategory { get; set; }
    }
}
