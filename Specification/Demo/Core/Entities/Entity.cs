namespace Specification.Demo.Core.Entities;

public class Entity<TId>
{
    public TId Id { get; protected set; }
}