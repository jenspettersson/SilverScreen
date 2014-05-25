using System;
using System.Collections.Generic;

namespace SilverScreen
{
    public interface IAggregate
    {
        Guid Id { get; }
        IEnumerable<IDomainEvent> GetUncommittedEvents();
        void Clear();
    }

    public interface IDomainEvent { }
}