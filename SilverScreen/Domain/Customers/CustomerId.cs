using System;

namespace SilverScreen.Domain.Customers
{
    public sealed class CustomerId : AbstractIdentity<Guid>
    {
        public override Guid Id { get; protected set; }

        public CustomerId(Guid id)
        {
            Id = id;
        }
    }
}