using JHI.Core.DomainDrivenDesign.Shared.Interfaces;

namespace JHI.Core.DomainDrivenDesign.DDD.Interfaces
{
    public interface IDomainEvent : IEvent
    {
        DateTime TimeStamp { get; set; }

        IAuditInfo AuditInfo { get; set; }

        long Version { get; set; }
    }
}
