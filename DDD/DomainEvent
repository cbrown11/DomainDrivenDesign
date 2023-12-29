namespace JHI.Core.DomainDrivenDesign.DDD
{
    using JHI.Core.DomainDrivenDesign.DDD.Interfaces;
    using JHI.Core.DomainDrivenDesign.Serializer;
    using JHI.Core.DomainDrivenDesign.Shared;
    using JHI.Core.DomainDrivenDesign.Shared.Interfaces;

    using Newtonsoft.Json;

    public class DomainEvent : IDomainEvent
    {
        public string Id { get; set; }

        [JsonConverter(typeof(ConcreteTypeConverter<AuditInfo>))]
        public IAuditInfo AuditInfo { get; set; }

        public long Version { get; set; }

        public DateTime TimeStamp { get; set; }

        // Need for deserialize 
        public DomainEvent()
        {
            TimeStamp = DateTime.UtcNow;
        }

        public DomainEvent(IAuditInfo auditInfo, string id, DateTime? timeStamp = null)
        {
            AuditInfo = auditInfo;
            if (!timeStamp.HasValue)
            {
                TimeStamp = DateTime.UtcNow;
            }
            else
            {
                TimeStamp = (DateTime)timeStamp;
            }

            Id = id;
        }

        public DomainEvent(IAuditInfo auditInfo, string id, int version, DateTime? timeStamp = null)
            : this(auditInfo, id, timeStamp)
        {
            Version = version;
        }
    }
}
