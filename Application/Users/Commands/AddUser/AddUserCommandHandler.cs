using Application.Common.Interfaces;
using Domain.Entities;
using Domain.Repository;
using MediatR;

namespace Application.Users.Commands.AddUser;

public class AddUserCommandHandler(IUnitOfWork _uow,IUserRepository _userRepository) : IRequestHandler<AddUserCommand,int>
{
    public async Task<int> Handle(AddUserCommand request, CancellationToken cancellationToken)
    {
        _userRepository
            .Add(new User() { });
        return await _uow.SaveAsync();
    }
}