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
        private readonly IUsersRepository _usersRepository;
        private readonly IBusPublisher _busPublisher;

        public CreateUserHandler(IUsersRepository usersRepository, IBusPublisher busPublisher)
        {
            _usersRepository = usersRepository;
            _busPublisher = busPublisher;
        }

        public async Task<CommandExecutionResult> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            // Unique email validation, it can be done by db
            var dbUser = _usersRepository.GetUserByEmail(request.Email);
            if(dbUser != null)
            {
                throw new ValidationException("Email should be unique");
            }

            var user = new User(Guid.NewGuid(), request.Email, request.FirstName, request.LastName);
            await _usersRepository.CreateUser(user);

            // Send event to kafka or other messaging system
            _busPublisher.Send(new UserCreatedEvent(user.Id, user.Email, user.FirstName, user.LastName));

            return new CommandExecutionResult() { Result = true };
        }
    }
}
