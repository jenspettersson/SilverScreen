using SilverScreen.Domain;
using SilverScreen.Domain.Customers;
using SilverScreen.Infrastructure;
using Xunit;

namespace SilverScreen.Tests.Domain
{
    public class CustomerTests
    {
        [Fact]
        public void Create_should_produce_CustomerCreatedEvent()
        {
            var customer = Customer.Create("Customer Name", "Adress");


            var repository = new Repository<Customer>(new InMemoryEventStore());

            repository.Save(customer);


            var reconstructed = repository.GetById(customer.Id);

        }
    }
}