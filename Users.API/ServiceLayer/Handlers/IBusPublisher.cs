namespace Users.API.ServiceLayer.Handlers
{
    public interface IBusPublisher
    {
        void Send(UserCreatedEvent userCreatedEvent);
    }
}