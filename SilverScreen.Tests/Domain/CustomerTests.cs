using SilverScreen.Domain.Customers;
using SilverScreen.Infrastructure;
using Xunit;

namespace SilverScreen.Tests.Domain
{
    public class CustomerTests : IUseFixture<TestFixture>
    {
        [Fact]
        public void Create_should_produce_CustomerCreatedEvent()
        {
            var customer = Customer.Create("Customer Name", "Adress");
            customer.Relocated("Relocated address");
            customer.ChangeName("New Name");


            var repository = new Repository<Customer>(new InMemoryEventStore());
            repository.Save(customer);


            var reconstructed = repository.GetById(customer.Id);
        }

        public void SetFixture(TestFixture data)
        {
            
        }
    }

    public class TestFixture
    {
        
    }
}