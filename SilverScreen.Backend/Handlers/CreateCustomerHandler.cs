using System;
using NServiceBus;
using SilverScreen.Messages;

namespace SilverScreen.Backend.Handlers
{
    public class CreateCustomerHandler : IHandleMessages<CreateCustomer>
    {
        public void Handle(CreateCustomer message)
        {
            Console.WriteLine("Handling CreateCustomer: {0}", message.Name);
        }
    }
}