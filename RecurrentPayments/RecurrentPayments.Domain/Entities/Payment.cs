using System;
using System.Collections.Generic;
using System.Text;

namespace RecurrentPayments.Domain.Entities
{
    public class Payment
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaidAt { get; set; } = DateTime.Now;
        public string Notes { get; set; } = string.Empty;

        public Invoice Invoice { get; set; } = null!;
    }
}
