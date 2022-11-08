namespace Repository.Demo.Core.Interfaces;
/// <summary>
/// A generic interface for CRUD work on any type of IEntity
/// </summary>
/// <typeparam name="TEntity"></typeparam>
/// <typeparam name="TId"></typeparam>
public interface IRepository<TEntity, in TId>
{
    TEntity GetById(TId id);
    IEnumerable<TEntity> List();
    void Add(TEntity entity);
    void Update(TEntity entity);
    void Delete(TId id);
}