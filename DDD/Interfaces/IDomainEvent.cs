using DomainDrivenDesign.Shared.Interfaces;

namespace DomainDrivenDesign.DDD.Interfaces
{
    public interface IDomainEvent : IEvent
    {
        DateTime TimeStamp { get; set; }

        IAuditInfo AuditInfo { get; set; }

        long Version { get; set; }
    }
}
