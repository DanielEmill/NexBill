using RecurrentPayments.Domain.Enums;

namespace RecurrentPayments.Application.DTOs;

public class ContractDto
{
    public int Id { get; set; }
    public int ClientId { get; set; }
    public string ClientName { get; set; } = string.Empty;
    public decimal Amount { get; set; }
    public BillingFrequency Frequency { get; set; }
    public string FrequencyDisplay => Frequency switch
    {
        BillingFrequency.Weekly => "Semanal",
        BillingFrequency.Biweekly => "Quincenal",
        BillingFrequency.Monthly => "Mensual",
        _ => ""
    };
    public DateOnly NextBillingDate { get; set; }
    public ContractStatus Status { get; set; }
    public string StatusDisplay => Status switch
    {
        ContractStatus.Active => "Activo",
        ContractStatus.Paused => "Pausado",
        ContractStatus.Cancelled => "Cancelado",
        _ => ""
    };
    public DateTime CreatedAt { get; set; }
}