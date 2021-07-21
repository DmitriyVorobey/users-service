using MediatR;
using System;

namespace Users.API.ServiceLayer.Handlers
{
    public class UserCreatedEvent : INotification
    {
        public Guid Id { get; }
        public string Email { get; }
        public string FirstName { get; }
        public string LastName { get; }

        public DateTime Created { get; }

        public UserCreatedEvent(Guid id, string email, string firstName, string lastName)
        {
            Id = id;
            Email = email;
            FirstName = firstName;
            LastName = lastName;

            Created = DateTime.UtcNow;
        }
    }
}