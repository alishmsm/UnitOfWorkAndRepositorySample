using Application.Common.Interfaces;
using Domain.Entities;
using Infrastructure.Context;

namespace Infrastructure.Repositories;

public class UnitOfWork(AppDbContext context) : IUnitOfWork
{
    private readonly AppDbContext _context = context;
    
    public async Task<int> SaveAsync()
    {
        return await _context.SaveChangesAsync();
    }
}