using System;

namespace SilverScreen
{
    public class State : IState
    {
        public Guid Id { get; set; }

        public void Mutate(IDomainEvent evt)
        {
            ((dynamic)this).When((dynamic)evt);
        }
    }
}