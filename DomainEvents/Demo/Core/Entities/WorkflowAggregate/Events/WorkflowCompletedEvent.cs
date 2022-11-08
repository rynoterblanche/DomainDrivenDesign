using DomainEvents.Demo.Shared.Interfaces;

namespace DomainEvents.Demo.Core.Entities.WorkflowAggregate.Events;

public class WorkflowCompletedEvent: IDomainEvent
{
    public Guid Id { get; }
    public Workflow WorkflowStarted { get; }
    public DateTime DateTimeEventOccurred { get; }

    public WorkflowCompletedEvent(Workflow workflow, DateTime started)
    {
        Id = Guid.NewGuid();
        WorkflowStarted = workflow;
        DateTimeEventOccurred = started;
    }
}