using CQRSUser.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Query.Models;
using System.Threading.Tasks;

namespace CQRSUser.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<UserViewModel> GetUser(int id)
        {
            var user = await _mediator.Send(new GetUserQuery(id));
            return user;
        }
    }
}
