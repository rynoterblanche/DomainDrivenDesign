using Repository.Demo.Core.Entities.WorkflowAggregate;
using Repository.Demo.Core.Interfaces;

namespace Repository.Demo.Data;

/// <summary>
/// An aggregate root repository for CRUD work specifically on Workflows
/// </summary>
public class WorkflowAggregateRepository : IRepository<Workflow, int>
{
    public Workflow GetById(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Workflow> List()
    {
        throw new NotImplementedException();
    }

    public void Add(Workflow entity)
    {
        throw new NotImplementedException();
    }

    public void Update(Workflow entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }
}