using Domain.Entities;
using Domain.Repository;
using Infrastructure.Context;
using Infrastructure.Repositories;

namespace Infrastructure.Repository;

public class OrderRepository(AppDbContext context) : 
    GenericRepository<Order>(context), IOrderRepository
    
{
    public async Task<Order> FindAsync(int id)
    {
        return await _context.Order.FindAsync(id);
    }
}