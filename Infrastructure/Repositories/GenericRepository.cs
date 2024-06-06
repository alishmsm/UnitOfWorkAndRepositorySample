using Application.Common.Interfaces;
using Domain.Entities;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class GenericRepository<TEntity>(AppDbContext context) where TEntity : class,IEntity
{
    protected readonly AppDbContext _context = context;
    public void Add(TEntity entity)
    {
        _context.Set<TEntity>().Add(entity);
        // context.Add(entity);
    }

    public async Task<TEntity> Get(int id)
    {
        return await _context.Set<TEntity>().FindAsync(id);
        // return await context.FindAsync(id);
    }

    public void Update(TEntity entity)
    {
        // context.Attach(entity);
        // context.Entry(entity).State = EntityState.Modified;
        _context.Set<TEntity>().Attach(entity);
        _context.Set<TEntity>().Entry(entity).State = EntityState.Modified;
    }

    public void Delete(TEntity entity)
    {
        _context.Set<TEntity>().Remove(entity);
        // context.Remove(entity);
    }
}