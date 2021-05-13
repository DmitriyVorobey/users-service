using MediatR;
using System;
using User.API.ServiceLayer.Handlers;

namespace User.API.ServiceLayer.Commands
{
    public class CreateUserCommand : IRequest<CommandExecutionResult>
    {
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Email { set; get; }
        public DateTime DateOfBirth { set; get; }
    }
}
