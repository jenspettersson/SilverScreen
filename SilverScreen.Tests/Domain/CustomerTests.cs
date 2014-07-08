using SilverScreen.Domain;
using SilverScreen.Domain.Customers;
using Xunit;

namespace SilverScreen.Tests.Domain
{
    public class CustomerTests
    {
        [Fact]
        public void Create_should_produce_CustomerCreatedEvent()
        {
            var customer = Customer.Create("Customer Name", "Adress");

            var uncommittedEvents = customer.GetUncommittedEvents();
        }
    }
}