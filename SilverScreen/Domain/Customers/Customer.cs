using System;

namespace SilverScreen.Domain.Customers
{
    public class Customer : AggregateBase<CustomerState>
    {
        public Customer(CustomerState state) : base(state) { }

        private Customer(CustomerId id, string name, string adress)
        {
            Apply(new CustomerCreated(id, name, adress));
        }

        public static Customer Create(string name, string address)
        {
            return new Customer(new CustomerId(Guid.NewGuid()), name, address);
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
}