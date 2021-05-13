using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using User.API.DataLayer.Model;
using User.API.DataLayer.Repositories;
using User.API.ServiceLayer.Commands;

namespace User.API.ServiceLayer.Handlers
{
    public class CreateUserHandler : IRequestHandler<CreateUserCommand, CommandExecutionResult>
    {
        private IUsersRepository _usersRepository;
        private IMapper _mapper;

        public CreateUserHandler(IUsersRepository usersRepository, IMapper mapper)
        {
            _usersRepository = usersRepository;
            _mapper = mapper;
        }

        public async Task<CommandExecutionResult> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            Validate(request);

            var user = _mapper.Map<UserDto>(request);
            await _usersRepository.CreateUser(user);

            return new CommandExecutionResult() { Result = true };
        }

        private void Validate(CreateUserCommand request)
        {
            if (string.IsNullOrEmpty(request.FirstName))
                throw new CommandValidationException("First name cannot be null or empty");

            if (string.IsNullOrEmpty(request.LastName))
                throw new CommandValidationException("Last name cannot be null or empty");

            if (string.IsNullOrEmpty(request.Email))
                throw new CommandValidationException("Email cannot be null or empty");
        }
    }
}
