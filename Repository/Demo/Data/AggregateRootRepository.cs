using Repository.Demo.Core.Interfaces;

namespace Repository.Demo.Data;

/// <summary>
/// A generic repository for CRUD work on types of IAggregateRoot only.
///
/// Constraining repositories to root with markers prevents direct access to the non-root
/// entities, or children, of that root.
/// </summary>
/// <typeparam name="TEntity"></typeparam>
/// <typeparam name="TId"></typeparam>
class AggregateRootRepository<TEntity, TId> : IRepository<TEntity, TId> 
    where TEntity : class, IAggregateRoot<TId>
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