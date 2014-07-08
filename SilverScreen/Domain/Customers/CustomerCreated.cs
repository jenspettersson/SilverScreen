namespace SilverScreen.Domain.Customers
{
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
}