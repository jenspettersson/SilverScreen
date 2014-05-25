using NServiceBus;

namespace SilverScreen.Messages
{
    public class CreateCustomer : ICommand
    {
        public string Name { get; set; }
        public string Adress { get; set; }

        public CreateCustomer(string name, string adress)
        {
            Name = name;
            Adress = adress;
        }
    }
}