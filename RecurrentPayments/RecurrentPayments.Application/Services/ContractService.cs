using Microsoft.EntityFrameworkCore;
using RecurrentPayments.Application.DTOs;
using RecurrentPayments.Domain.Entities;
using RecurrentPayments.Domain.Enums;
using RecurrentPayments.Infrastructure.Persistence;

namespace RecurrentPayments.Application.Services;

public class ContractService
{
    private readonly AppDbContext _db;

    public ContractService(AppDbContext db) => _db = db;

    public async Task<List<ContractDto>> GetAllAsync()
    {
        return await _db.Contracts
            .Include(c => c.Client)
            .OrderByDescending(c => c.CreatedAt)
            .Select(c => new ContractDto
            {
                Id = c.Id,
                ClientId = c.ClientId,
                ClientName = c.Client.Name,
                Amount = c.Amount,
                Frequency = c.Frequency,
                NextBillingDate = c.NextBillingDate,
                Status = c.Status,
                CreatedAt = c.CreatedAt
            })
            .ToListAsync();
    }

    public async Task CreateAsync(ContractDto dto)
    {
        var contract = new Contract
        {
            ClientId = dto.ClientId,
            Amount = dto.Amount,
            Frequency = dto.Frequency,
            NextBillingDate = dto.NextBillingDate,
            Status = ContractStatus.Active
        };

        _db.Contracts.Add(contract);
        await _db.SaveChangesAsync();
    }

    public async Task UpdateAsync(ContractDto dto)
    {
        var contract = await _db.Contracts.FindAsync(dto.Id)
            ?? throw new Exception("Contrato no encontrado");

        contract.ClientId = dto.ClientId;
        contract.Amount = dto.Amount;
        contract.Frequency = dto.Frequency;
        contract.NextBillingDate = dto.NextBillingDate;
        contract.Status = dto.Status;

        await _db.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var contract = await _db.Contracts.FindAsync(id)
            ?? throw new Exception("Contrato no encontrado");

        _db.Contracts.Remove(contract);
        await _db.SaveChangesAsync();
    }
}