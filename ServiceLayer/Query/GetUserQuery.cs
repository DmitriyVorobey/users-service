using CQRSUser.Models;
using MediatR;

namespace ServiceLayer.Query.Models
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
