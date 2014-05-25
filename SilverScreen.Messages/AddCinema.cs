using NServiceBus;

namespace SilverScreen.Messages
{
    public class AddCinema : ICommand
    {
        public string Name { get; set; }

        public AddCinema(string name)
        {
            Name = name;
        }
    }
}