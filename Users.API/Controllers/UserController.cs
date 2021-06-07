using System.Threading.Tasks;
using AutoMapper;
using CQRSUser.ServiceLayer.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using User.API.Models;
using User.API.ServiceLayer.Commands;

namespace User.API.Controllers
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

        [HttpGet("{id}")]
        public async Task<UserViewModel> GetUser(int id)
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
