using Murimi.ApplicationCore.SharedKernel;
using System;

namespace Murimi.ApplicationCore.Entities.SalesInvoiceAggregate
{
    public class InvoicedItem // Value Object
    {
        public Guid ItemId { get; private set; }

        public string ItemName { get; private set; }

        public string ItemDescription { get; private set; }

        private InvoicedItem()
        {
            // Required by EF
        }

        public InvoicedItem(Guid itemId, string itemName, string itemDescription)
        {
            Guard.AgainstNull(itemId, nameof(itemId));
            Guard.AgainstNullOrEmpty(itemName, nameof(itemName));
            Guard.AgainstNullOrEmpty(itemDescription, nameof(itemDescription));

            ItemId = itemId;
            ItemName = itemName;
            ItemDescription = itemDescription;
        }
    }
}
