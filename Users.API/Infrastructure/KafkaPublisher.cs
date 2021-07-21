using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using Users.API.ServiceLayer.Handlers;

namespace Users.API.Infrastructure
{
    public class KafkaPublisher : INotificationHandler<UserCreatedEvent>
    {
        public Task Handle(UserCreatedEvent notification, CancellationToken cancellationToken)
        {
            Console.WriteLine($"Message has been sent to kafka with {notification.Id}!");

            return Task.CompletedTask;
        }
    }
}
