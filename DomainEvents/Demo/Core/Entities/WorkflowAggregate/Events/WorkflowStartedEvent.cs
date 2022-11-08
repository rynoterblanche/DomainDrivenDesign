using DomainEvents.Demo.Shared.Interfaces;

namespace DomainEvents.Demo.Core.Entities.WorkflowAggregate.Events;

public class WorkflowStartedEvent: IDomainEvent
{
    public Guid Id { get; }
    public Workflow Workflow { get; }
    public DateTime DateTimeEventOccurred { get; }

    public WorkflowStartedEvent(Workflow workflow, DateTime started)
    {
        Id = Guid.NewGuid();
        Workflow = workflow;
        DateTimeEventOccurred = started;
    }
}