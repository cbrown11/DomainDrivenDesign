using DomainDrivenDesign.Shared;
using DomainDrivenDesign.Shared.Interfaces;

namespace DomainDrivenDesign.Shared
{

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
