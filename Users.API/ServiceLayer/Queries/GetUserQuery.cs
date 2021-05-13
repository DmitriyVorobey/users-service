using MediatR;
using User.API.Models;

namespace CQRSUser.ServiceLayer.Queries
{
    public class GetUserQuery : IRequest<UserViewModel>
    {
        public GetUserQuery(int id)
        {
            Id = id;
        }

        public int Id { get; }
    }
}
