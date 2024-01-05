using DomainDrivenDesign.Interfaces;

namespace DomainDrivenDesign.Interfaces

{
    public interface IAggregate
    {
        int Version { get; }

        string AggregateId { get; }

        void ApplyEvent(IDomainEvent @event);

        IEnumerable<IDomainEvent> UncommitedEvents();

        void ClearUncommitedEvents();
    }
}
