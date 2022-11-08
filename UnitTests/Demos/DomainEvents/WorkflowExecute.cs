using DomainEvents.Demo.Core.Entities.WorkflowAggregate;
using DomainEvents.Demo.Core.Entities.WorkflowAggregate.Events;

namespace UnitTests.Demos.DomainEvents;

public class WorkflowExecute
{
    [Fact]
    public void RaisesStatusChangeEvents()
    {
        var workflow = new Workflow("Workflow A");

        workflow.Execute();

        Assert.IsType<WorkflowStartedEvent>(workflow.DomainEvents.First());
        Assert.IsType<WorkflowCompletedEvent>(workflow.DomainEvents.Last());
    }
}