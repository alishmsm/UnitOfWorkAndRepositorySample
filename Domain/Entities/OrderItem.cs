namespace Domain.Entities;

public class OrderItem : IEntity
{
    public long Id { get; set; }

    public long OrderId { get; set; }

    public Order Order { get; set; }

    public string Name { get; set; }

    public int Quantity { get; set; }
    public long Price { get; set; }
}