using Domain.Entities;

namespace Application.Common.Interfaces;

public interface IUnitOfWork
{
    Task<int> SaveAsync();
}