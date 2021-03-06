using Murimi.ApplicationCore.Entities.SalesInvoiceAggregate;
using System;

namespace Murimi.ApplicationCore.Specifications
{
    public class SalesInvoiceSpecification : BaseSpecification<SalesInvoice>
    {
        public SalesInvoiceSpecification(Guid salesInvoiceId)
            : base(si => si.Id == salesInvoiceId)
        {
            AddInclude(o => o.SalesInvoiceItems);
            AddInclude($"{nameof(SalesInvoice.SalesInvoiceItems)}.{nameof(SalesInvoiceItem.InvoicedItem)}");
            AddInclude($"{nameof(SalesInvoice.SalesInvoiceItems)}.{nameof(SalesInvoiceItem.Tax)}");
        }

        public SalesInvoiceSpecification(Guid? customerId)
            : base(si => si.CustomerId == customerId)
        {
            ApplyOrderByDescending(i => i.InvoiceDate);
        }

    }
}
