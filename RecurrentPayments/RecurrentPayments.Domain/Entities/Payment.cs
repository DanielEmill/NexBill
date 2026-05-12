using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RecurrentPayments.Domain.Entities
{
    public class Payment
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }

        [Range(0.01, 9999999)]
        public decimal Amount { get; set; }

        public DateTime PaidAt { get; set; } = DateTime.Now;

        [MaxLength(300)]
        public string Notes { get; set; } = string.Empty;

        public Invoice Invoice { get; set; } = null!;
    }
}
