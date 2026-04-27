
using Common.Models.AuditInfo;
using Common.Models.Messages;

namespace DomainDrivenDesign.Interfaces
{
    public interface IDomainEvent : IEvent
    {
        DateTime TimeStamp { get; set; }

        IAuditInfo AuditInfo { get; set; }

        long Version { get; set; }
    }
}
