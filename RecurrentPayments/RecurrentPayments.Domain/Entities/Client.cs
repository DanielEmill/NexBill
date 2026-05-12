using System;
using System.Collections.Generic;
using System.Text;

namespace RecurrentPayments.Domain.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public ICollection<Contract> Contracts { get; set; } = new List<Contract>();
    }
}
