using RecurrentPayments.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using RecurrentPayments.Domain.Enums;

namespace RecurrentPayments.Domain.Entities
{
    public class Invoice
    {
        public int Id { get; set; }
        public int ContractId { get; set; }
        public decimal Amount { get; set; }
        public decimal PaidAmount { get; set; } = 0;
        public DateOnly BillingDate { get; set; }
        public InvoiceStatus Status { get; set; } = InvoiceStatus.Pending;
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public decimal Balance => Amount - PaidAmount;

        public Contract Contract { get; set; } = null!;
        public ICollection<Payment> Payments { get; set; } = new List<Payment>();
    }
}
