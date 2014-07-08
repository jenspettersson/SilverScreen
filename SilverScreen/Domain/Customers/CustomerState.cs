namespace SilverScreen.Domain.Customers
{
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