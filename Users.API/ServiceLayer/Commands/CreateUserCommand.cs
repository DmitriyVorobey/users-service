using MediatR;
using System;
using Users.API.ServiceLayer.Handlers;

namespace Users.API.ServiceLayer.Commands
{
    public class CreateUserCommand : IRequest<CommandExecutionResult>
    {
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Email { set; get; }
    }
}
