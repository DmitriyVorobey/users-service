using MediatR;

namespace User.API.ServiceLayer.Commands
{
    public class CreateUserCommand : IRequest
    {
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Email { set; get; }
        public int Age { set; get; }
    }
}
