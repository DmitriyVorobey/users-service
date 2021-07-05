using System;

namespace Users.API.ServiceLayer.Handlers
{
    internal class UserCreatedEvent
    {
        private Guid id;
        private string email;
        private string firstName;
        private string lastName;

        public UserCreatedEvent(Guid id, string email, string firstName, string lastName)
        {
            this.id = id;
            this.email = email;
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}