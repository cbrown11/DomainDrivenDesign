namespace DomainDrivenDesign.Shared.Interfaces
{
    public interface IAuditInfo
    {
        DateTime Created { get; set; }

        string By { get; set; }
    }
}
