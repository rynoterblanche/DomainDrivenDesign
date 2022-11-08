using System.Linq.Expressions;
using Specification.Rt.Specification;

namespace Specification.Demo.Core.Entities.WorkflowAggregate.Specifications;

public class WorkflowsReadyToRun: Specification<Workflow>
{
    private readonly DateTime _runOnOrAfter;

    public WorkflowsReadyToRun(DateTime runOnOrAfter)
    {
        _runOnOrAfter = runOnOrAfter;
    }

    public override Expression<Func<Workflow, bool>> ToExpression()
    {
        return wf => wf.Tasks.Any() &&
                     wf.RunDate >= _runOnOrAfter;
    }
}