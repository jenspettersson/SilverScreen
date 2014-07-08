using System;
using SilverScreen.Domain;

namespace SilverScreen.Infrastructure
{
    public class Repository<T> : IRepository<T> where T : IAggregate, new()
    {
        private readonly IEventStore _store;

        public Repository(IEventStore store)
        {
            _store = store;
        }

        public void Save(T aggregate)
        {
            _store.SaveEvents(aggregate.Id, aggregate.GetUncommittedEvents());
        }

        public T GetById(IIdentity id)
        {
            var events = _store.GetEventsByAggregateId(id);
            var obj = new T();

            obj.ReconstructFromHistory(events);

            return obj;
        }
    }

    public interface IRepository<T>
    {
        void Save(T aggregate);
        T GetById(IIdentity id);
    }
}