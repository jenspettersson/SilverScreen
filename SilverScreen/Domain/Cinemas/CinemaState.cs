using System.Collections.Generic;
using SilverScreen.Domain.Screens;

namespace SilverScreen.Domain.Cinemas
{
	public class CinemaState : State
	{
		public string Name { get; set; }

		public List<Screen> Screens { get; set; }

		public void When(CinemaAdded evt)
		{
			Id = evt.Id;
			Name = evt.Name;
		}
	}
}