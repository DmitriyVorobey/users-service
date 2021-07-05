using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Users.API.DataLayer.Repositories;
using Users.API.Models;
using Users.API.ServiceLayer.Queries;

namespace Users.API.ServiceLayer.Handlers
{
    public class GetUserDetailHandler : IRequestHandler<GetUserQuery, UserViewModel>
    {
        private readonly IUsersRepository _usersRepository;
        private readonly IMapper _mapper;

        public GetUserDetailHandler(IUsersRepository usersRepository, IMapper mapper)
        {
            _usersRepository = usersRepository;
            _mapper = mapper;
        }

        public async Task<UserViewModel> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            var dbUser = await _usersRepository.GetUser(request.Id);
            return _mapper.Map<UserViewModel>(dbUser);
        }
    }
}
