namespace JHI.Core.DomainDrivenDesign.Shared.Interfaces
{ 
    public interface IEvent : IMessage
    {
        string Id { get; }
    }
}
