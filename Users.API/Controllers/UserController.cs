using System;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Users.API.Models;
using Users.API.ServiceLayer.Commands;
using Users.API.ServiceLayer.Queries;

namespace Users.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public UsersController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        // TODO: Add get users endpoint
        [HttpGet("{id}")]
        public async Task<UserViewModel> GetUser(Guid id)
        {
            var user = await _mediator.Send(new GetUserQuery(id));
            return user;
        }

        [HttpPost]
        public async Task CreateUser(CreateUserModel model)
        {
            var createUserCommand = _mapper.Map<CreateUserCommand>(model);
            await _mediator.Send(createUserCommand);
        }
    }
}
