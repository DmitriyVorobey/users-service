using MediatR;
using System;
using Users.API.Models;

namespace Users.API.ServiceLayer.Queries
{
    public class GetUserQuery : IRequest<UserViewModel>
    {
        public GetUserQuery(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; }
    }
}
