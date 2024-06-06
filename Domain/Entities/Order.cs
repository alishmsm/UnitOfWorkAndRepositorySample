namespace Domain.Entities;

public class Order : IEntity
{
    public long Id { get; set; }
    public string Code { get; set; }
    public DateOnly Date { get; set; }
    public TimeOnly time { get; set; }
    public ICollection<OrderItem> OrderItems { get; set; }
}