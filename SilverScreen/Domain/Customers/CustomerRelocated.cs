namespace SilverScreen.Domain.Customers
{
    public class CustomerRelocated : IDomainEvent
    {
        public string Address { get; private set; }

        public CustomerRelocated(string address)
        {
            Address = address;
        }
    }
}