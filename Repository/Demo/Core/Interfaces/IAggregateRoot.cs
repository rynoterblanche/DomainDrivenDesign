namespace Repository.Demo.Core.Interfaces;

/// <summary>
/// Marker interface that provides protection to aggregates
///
/// This marker must only be applied to aggregate root entities
/// </summary>
/// <typeparam name="TId"></typeparam>
public interface IAggregateRoot<out TId> : IEntity<TId> { }