namespace Aggregate.Entities;

public class Entity<TId>
{
    public TId Id { get; protected set; }
}