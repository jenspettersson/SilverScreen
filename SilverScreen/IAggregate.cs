using System.Collections.Generic;

namespace SilverScreen
{
    public interface IAggregate
    {
        IEnumerable<IDomainEvent> GetUncommittedEvents();
        void Clear();
    }
}