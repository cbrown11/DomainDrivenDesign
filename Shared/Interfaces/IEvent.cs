namespace DomainDrivenDesign.Shared.Interfaces
{ 
    public interface IEvent : IMessage
    {
        string Id { get; }
    }
}
