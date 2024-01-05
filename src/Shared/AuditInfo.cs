namespace DomainDrivenDesign.Shared
{
    using DomainDrivenDesign.Shared.Interfaces;

    public class AuditInfo : IAuditInfo
    {
        public AuditInfo()
        {
            this.Created = DateTime.UtcNow;
        }

        public AuditInfo(string by)
            : this()
        {
            this.By = by;
        }

        public DateTime Created { get; set; }

        public string By { get; set; }
    }
}
