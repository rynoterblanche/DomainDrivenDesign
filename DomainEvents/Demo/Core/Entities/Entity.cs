using System.ComponentModel.DataAnnotations.Schema;
using DomainEvents.Demo.Shared.Interfaces;

namespace DomainEvents.Demo.Core.Entities;

public class Entity<TId>
{
    public TId Id { get; protected set; }

    private List<IDomainEvent> _domainEvents = new();

    [NotMapped]
    public IEnumerable<IDomainEvent> DomainEvents => _domainEvents.AsReadOnly();

    protected void RegisterDomainEvent(IDomainEvent domainEvent) => _domainEvents.Add(domainEvent);
    internal void ClearDomainEvents() => _domainEvents.Clear();
}