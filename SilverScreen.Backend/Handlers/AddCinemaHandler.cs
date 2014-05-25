using System;
using NServiceBus;
using SilverScreen.Messages;

namespace SilverScreen.Backend.Handlers
{
    public class AddCinemaHandler : IHandleMessages<AddCinema>
    {
        public void Handle(AddCinema message)
        {
            Console.WriteLine("Handling AddCinema: {0}", message.Name);
        }
    }
}