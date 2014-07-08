using System;

namespace SilverScreen.Domain.Customers
{
    public class Customer : AggregateBase<CustomerState>
    {
        public Customer(CustomerState state) : base(state) { }

        public Customer()
        {
            
        }

        private Customer(CustomerId id, string name, string address)
        {
            Apply(new CustomerCreated(id, name, address));
        }

        public static Customer Create(string name, string address)
        {
            return new Customer(new CustomerId(Guid.NewGuid().ToString()), name, address);
        }
        
        public void ChangeName(string name)
        {
            Apply(new CustomerNameChanged(name));
        }

        public void Relocated(string address)
        {
            Apply(new CustomerRelocated(address));
        }
    }
}