using System;

namespace SilverScreen
{
    public interface IState
    {
        Guid Id { get; set; }
        void Mutate(IDomainEvent evt);
    }
}