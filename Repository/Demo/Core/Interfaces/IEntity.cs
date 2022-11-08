namespace Repository.Demo.Core.Interfaces;

public interface IEntity<out TId>
{
    TId Id { get; }
}