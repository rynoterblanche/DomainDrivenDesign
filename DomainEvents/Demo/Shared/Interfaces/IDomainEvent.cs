namespace DomainEvents.Demo.Shared.Interfaces;

public interface IDomainEvent
{
    DateTime DateTimeEventOccurred { get; }
}