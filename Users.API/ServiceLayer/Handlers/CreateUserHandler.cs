using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using User.API.DataLayer.Model;
using User.API.DataLayer.Repositories;
using User.API.ServiceLayer.Commands;

namespace User.API.ServiceLayer.Handlers
{
    public class CreateUserHandler : IRequestHandler<CreateUserCommand>
    {
        private IUsersRepository _usersRepository;
        private IMapper _mapper;

        public CreateUserHandler(IUsersRepository usersRepository, IMapper mapper)
        {
            _usersRepository = usersRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = _mapper.Map<UserDto>(request);
            await _usersRepository.CreateUser(user);


            return Unit.Value;
        }
    }
}
