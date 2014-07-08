using System;
using System.Collections.Generic;

namespace SilverScreen.Infrastructure
{
    public interface IEventStore
    {
        void SaveEvents(Guid id, IEnumerable<IDomainEvent> events);
        IEnumerable<IDomainEvent> GetEventsByAggregateId(Guid id);
    }

    public static class MemoryStore
    {
        private static readonly IDictionary<Guid, List<IDomainEvent>> Events = new Dictionary<Guid, List<IDomainEvent>>();
        public static void Put(Guid id, IEnumerable<IDomainEvent> events)
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

        public static IEnumerable<IDomainEvent> Get(Guid id)
        {
            if (Events.ContainsKey(id))
                return Events[id];

            return new List<IDomainEvent>();
        } 
    }
    public class InMemoryEventStore : IEventStore
    {
        public void SaveEvents(Guid id, IEnumerable<IDomainEvent> events)
        {
            MemoryStore.Put(id, events);
        }

        public IEnumerable<IDomainEvent> GetEventsByAggregateId(Guid id)
        {
            return MemoryStore.Get(id);
        }
    }
}