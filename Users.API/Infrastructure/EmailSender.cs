using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using Users.API.ServiceLayer.Handlers;

namespace Users.API.Infrastructure
{
    public class EmailSender : INotificationHandler<UserCreatedEvent>
    {
        public Task Handle(UserCreatedEvent notification, CancellationToken cancellationToken)
        {
            Console.WriteLine($"Message has been sent to email {notification.Email}!");

            return Task.CompletedTask;
        }
    }
}
