namespace SilverScreen.Domain.Customers
{
    public class CustomerNameChanged : IDomainEvent
    {
        public string Name { get; private set; }

        public CustomerNameChanged(string name)
        {
            Name = name;
        }
    }
}