using System;

namespace SilverScreen.Domain
{
    public interface IIdentity
    {
        string GetId();
    }

    public abstract class AbstractIdentity<TKey> : IIdentity
    {
        public abstract TKey Id { get; protected set; }

        public string GetId()
        {
            return Id.ToString();
        }
    }

    public sealed class CustomerId : AbstractIdentity<Guid>
    {
        public override Guid Id { get; protected set; }

        public CustomerId(Guid id)
        {
            Id = id;
        }
    }

    public class Customer : AggregateBase<CustomerState>
    {
        public Customer(CustomerState state) : base(state) { }

        private Customer(CustomerId id, string name, string adress)
        {
            Apply(new CustomerCreated(id, name, adress));
        }

        public static Customer Create(string name, string adress)
        {
            return new Customer(new CustomerId(Guid.NewGuid()), name, adress);
        }
        
        public void ChangeName(string name)
        {
            Apply(new CustomerNameChanged(name));
        }

        public void Relocated(string adress)
        {
            Apply(new CustomerRelocated(adress));
        }
    }

    public class CustomerRelocated : IDomainEvent
    {
        public string Adress { get; private set; }

        public CustomerRelocated(string adress)
        {
            Adress = adress;
        }
    }

    public class CustomerNameChanged : IDomainEvent
    {
        public string Name { get; private set; }

        public CustomerNameChanged(string name)
        {
            Name = name;
        }
    }

    public class CustomerCreated : IDomainEvent
    {
        public CustomerId Id { get; private set; }
        public string Name { get; private set; }
        public string Adress { get; private set; }

        public CustomerCreated(CustomerId id, string name, string adress)
        {
            Id = id;
            Name = name;
            Adress = adress;
        }
    }

    public class CustomerState : State
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public void When(CustomerCreated evt)
        {
            Name = evt.Name;
            Address = evt.Adress;
        }

        public void When(CustomerNameChanged evt)
        {
            Name = evt.Name;
        }

        public void When(CustomerRelocated evt)
        {
            Address = evt.Adress;
        }
    }
}