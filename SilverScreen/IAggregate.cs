using System.Collections.Generic;
using SilverScreen.Domain;

namespace SilverScreen
{
    public interface IAggregate
    {
        IEnumerable<IDomainEvent> GetUncommittedEvents();
        void Clear();
        void ReconstructFromHistory(IEnumerable<IDomainEvent> events);
    }
}