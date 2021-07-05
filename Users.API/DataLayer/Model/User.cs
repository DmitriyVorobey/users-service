using System;
using System.ComponentModel.DataAnnotations;

namespace Users.API.DataLayer.Model
{
    // Aggregate
    public class User
    {
        public Guid Id { get; }
        public string Email { get; }
        public string FirstName { get; }
        public string LastName { get; }

        public User(Guid id, string email, string firstName, 
                        string lastName)
        {
            if (string.IsNullOrEmpty(firstName))
                throw new ValidationException("First name cannot be null or empty");

            if (string.IsNullOrEmpty(lastName))
                throw new ValidationException("Last name cannot be null or empty");

            if (string.IsNullOrEmpty(email))
                throw new ValidationException("Email cannot be null or empty");

            Id = id;
            Email = email;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
