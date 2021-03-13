using AutoMapper;
using CQRSUser.DataLayer.Repositories;
using CQRSUser.Models;
using MediatR;
using ServiceLayer.Query.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSUser.ServiceLayer.Handler
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
