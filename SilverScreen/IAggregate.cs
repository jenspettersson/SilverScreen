﻿using System.Collections.Generic;
using SilverScreen.Domain;

namespace SilverScreen
{
    public interface IAggregate
    {
        IIdentity Id { get; }
        IEnumerable<IDomainEvent> GetUncommittedEvents();
        void Clear();
        void ReconstructFromHistory(IEnumerable<IDomainEvent> events);
    }
}