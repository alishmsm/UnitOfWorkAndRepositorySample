using Domain.Entities;

namespace Domain.Repository;

public interface IOrderRepository
{
    void Add(Order order);
    Task<Order> FindAsync(int id);
}