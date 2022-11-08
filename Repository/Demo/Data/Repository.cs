using Repository.Demo.Core.Interfaces;

namespace Repository.Demo.Data;

/// <summary>
/// An generic implementation for CRUD work on any type of IEntity
/// </summary>
/// <typeparam name="TEntity"></typeparam>
/// <typeparam name="TId"></typeparam>
class Repository<TEntity, TId> : IRepository<TEntity, TId>
{
    public TEntity GetById(TId id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<TEntity> List()
    {
        throw new NotImplementedException();
    }

    public void Add(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public void Update(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(TId id)
    {
        throw new NotImplementedException();
    }
}