using Microsoft.EntityFrameworkCore;
using RecurrentPayments.Application.DTOs;
using RecurrentPayments.Domain.Entities;
using RecurrentPayments.Infrastructure.Persistence;

namespace RecurrentPayments.Application.Services;

public class ClientService
{
    private readonly AppDbContext _db;

    public ClientService(AppDbContext db)
    {
        _db = db;
    }

    public async Task<List<ClientDto>> GetAllAsync()
    {
        return await _db.Clients
            .OrderBy(c => c.Name)
            .Select(c => new ClientDto
            {
                Id = c.Id,
                Name = c.Name,
                Phone = c.Phone,
                Email = c.Email,
                CreatedAt = c.CreatedAt
            })
            .ToListAsync();
    }

    public async Task CreateAsync(ClientDto dto)
    {
        var client = new Client
        {
            Name = dto.Name.Trim(),
            Phone = dto.Phone.Trim(),
            Email = dto.Email.Trim()
        };

        _db.Clients.Add(client);
        await _db.SaveChangesAsync();
    }

    public async Task UpdateAsync(ClientDto dto)
    {
        var client = await _db.Clients.FindAsync(dto.Id)
            ?? throw new Exception("Cliente no encontrado");

        client.Name = dto.Name.Trim();
        client.Phone = dto.Phone.Trim();
        client.Email = dto.Email.Trim();

        await _db.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var client = await _db.Clients.FindAsync(id)
            ?? throw new Exception("Cliente no encontrado");

        _db.Clients.Remove(client);
        await _db.SaveChangesAsync();
    }
}