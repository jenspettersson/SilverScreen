namespace SilverScreen.Domain.Customers
{
    public class CustomerRelocated : IDomainEvent
    {
        public string Adress { get; private set; }

        public CustomerRelocated(string adress)
        {
            Adress = adress;
        }
    }
}