using Domain.Entities;

namespace Domain.Repository;

public interface IUserRepository
{
    void Add(User user);
}