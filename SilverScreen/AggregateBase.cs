using System.Collections.Generic;
using SilverScreen.Domain;

namespace SilverScreen
{
    public abstract class AggregateBase<TState> : IAggregate where TState : IState, new()
    {

        public IEnumerable<IDomainEvent> GetUncommittedEvents()
        {
            return _changes;
        }

        public void Clear()
        {
            _changes.Clear();
        }

        protected TState State;
        protected AggregateBase()
        {
            State = new TState();
        }

        protected AggregateBase(TState state)
        {
            State = state;
        }

        private readonly IList<IDomainEvent> _changes = new List<IDomainEvent>();

        public void ReconstructFromHistory(IEnumerable<IDomainEvent> events)
        {
            foreach (var domainEvent in events)
            {
                State.Mutate(domainEvent);
            }
        }

        public void Apply(IDomainEvent evt)
        {
            State.Mutate(evt);
            _changes.Add(evt);
        }
    }
}