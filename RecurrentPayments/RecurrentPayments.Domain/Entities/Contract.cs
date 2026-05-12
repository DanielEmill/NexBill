using RecurrentPayments.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RecurrentPayments.Domain.Entities
{
    public class Contract
    {
        public int Id { get; set; }
        public int ClientId { get; set; }

        [Range(1, 9999999)]
        public decimal Amount { get; set; }

        public BillingFrequency Frequency { get; set; }
        public DateOnly NextBillingDate { get; set; }
        public ContractStatus Status { get; set; } = ContractStatus.Active;
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public Client Client { get; set; } = null!;
        public ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();
    }
}
