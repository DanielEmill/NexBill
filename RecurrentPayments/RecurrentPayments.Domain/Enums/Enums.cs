using System;
using System.Collections.Generic;
using System.Text;

namespace RecurrentPayments.Domain.Enums
{
    public enum BillingFrequency { Weekly, Biweekly, Monthly }
    public enum InvoiceStatus { Pending, PartiallyPaid, Paid }
    public enum ContractStatus { Active, Paused, Cancelled }
}
