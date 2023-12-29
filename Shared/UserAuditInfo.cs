namespace JHI.Core.DomainDrivenDesign.Shared
{
    using JHI.Core.DomainDrivenDesign.Shared.Interfaces;

    public class UserAuditInfo : AuditInfo, IAuditInfo
    {
        public UserAuditInfo(string id, string fullName)
            : base(fullName)
        {
            this.FullName = fullName;
        }

        public string FullName { get; set; }
    }
}
