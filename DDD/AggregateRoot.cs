// Copyright (c) Janus Henderson Investors. All rights reserved.
namespace DomainDrivenDesign.DDD
{
    using DomainDrivenDesign.DDD.Interfaces;


    public abstract class AggregateRoot : IAggregate
    {
        public abstract string AggregateId { get; }

        public int Version
        {
            get { return version; }
            protected set { version = value; }
        }

        private List<IDomainEvent> uncommitedEvents = new List<IDomainEvent>();
        private Dictionary<Type, Action<IDomainEvent>> routes = new Dictionary<Type, Action<IDomainEvent>>();
        private int version = -1;

        protected void RegisterTransition<T>(Action<T> transition)
            where T : class
        {
            routes.Add(typeof(T), o => transition(o as T));
        }

        public void RaiseEvent(IDomainEvent @event)
        {
            ApplyEvent(@event);
            uncommitedEvents.Add(@event);
        }

        public void ApplyEvent(IDomainEvent @event)
        {
            var eventType = @event.GetType();
            if (routes.ContainsKey(eventType))
            {
                routes[eventType](@event);
            }

            Version++;
        }

        public IEnumerable<IDomainEvent> UncommitedEvents()
        {
            return uncommitedEvents;
        }

        public void ClearUncommitedEvents()
        {
            uncommitedEvents.Clear();
        }
    }
}
