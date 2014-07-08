using System;
using System.Collections.Generic;
using SilverScreen.Domain;

namespace SilverScreen.Infrastructure
{
    public interface IEventStore
    {
        void SaveEvents(IIdentity id, IEnumerable<IDomainEvent> events);
        IEnumerable<IDomainEvent> GetEventsByAggregateId(IIdentity id);
    }

    public static class MemoryStore
    {
        private static readonly IDictionary<IIdentity, List<IDomainEvent>> Events = new Dictionary<IIdentity, List<IDomainEvent>>();
        public static void Put(IIdentity id, IEnumerable<IDomainEvent> events)
        {
            List<IDomainEvent> storedEvents;
            if(Events.ContainsKey(id))
                storedEvents = Events[id];
            else
            {
                storedEvents = new List<IDomainEvent>();
                Events[id] = storedEvents;
            }

            storedEvents.AddRange(events);
        }

        public static IEnumerable<IDomainEvent> Get(IIdentity id)
        {
            if (Events.ContainsKey(id))
                return Events[id];

            return new List<IDomainEvent>();
        } 
    }
    public class InMemoryEventStore : IEventStore
    {
        public void SaveEvents(IIdentity id, IEnumerable<IDomainEvent> events)
        {
            MemoryStore.Put(id, events);
        }

        public IEnumerable<IDomainEvent> GetEventsByAggregateId(IIdentity id)
        {
            return MemoryStore.Get(id);
        }
    }
}