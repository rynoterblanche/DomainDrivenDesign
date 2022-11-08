using System.Linq.Expressions;
using Specification.Rt.Specification;

namespace Specification.Demo.Core.Entities.WorkflowAggregate.Specifications;

public class WorkflowByIdWithActiveTasksSpecification: Specification<Workflow>
{
    private readonly Guid _workflowId;

    public WorkflowByIdWithActiveTasksSpecification(Guid workflowId)
    {
        _workflowId = workflowId;
    }

    public override Expression<Func<Workflow, bool>> ToExpression()
    {
        return wf => wf.Id == _workflowId &&
                     wf.Tasks.Any(wft => wft.IsDone == false);
    }
}