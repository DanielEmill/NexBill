using System;
using System.Collections.Generic;
using System.Text;
using RecurrentPayments.Domain.Enums;

namespace RecurrentPayments.Domain.Entities
{
    public class Contract
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public decimal Amount { get; set; }
        public BillingFrequency Frequency { get; set; }
        public DateOnly NextBillingDate { get; set; }
        public ContractStatus Status { get; set; } = ContractStatus.Active;
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public Client Client { get; set; } = null!;
        public ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();
    }
}
