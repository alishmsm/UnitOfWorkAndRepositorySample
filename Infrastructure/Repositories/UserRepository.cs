using Domain.Entities;
using Domain.Repository;
using Infrastructure.Context;
using Infrastructure.Repositories;

namespace Infrastructure.Repository;

public class UserRepository(AppDbContext context) : GenericRepository<User>(context), IUserRepository
{
}