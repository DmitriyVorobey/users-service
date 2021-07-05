using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using Users.API.DataLayer.Model;
using Users.API.DataLayer.Repositories;
using Users.API.ServiceLayer.Commands;

namespace Users.API.ServiceLayer.Handlers
{
    public class CreateUserHandler : IRequestHandler<CreateUserCommand, CommandExecutionResult>
    {
        private IUsersRepository _usersRepository;

        public CreateUserHandler(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        public async Task<CommandExecutionResult> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = new User(Guid.NewGuid(), request.Email, request.FirstName, request.LastName);
            await _usersRepository.CreateUser(user);

            return new CommandExecutionResult() { Result = true };
        }
    }
}
