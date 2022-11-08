namespace DomainEvents.Demo.Shared.Interfaces;

public interface IDomainEventHandler<TEvent> where TEvent : IDomainEvent
{
    void Handle(TEvent domainEvent);
}