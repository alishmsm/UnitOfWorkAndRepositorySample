namespace Domain.Entities;

public class User : IEntity
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string MobilNumber { get; set; }
    public ICollection<Order> Orders { get; set; }
}