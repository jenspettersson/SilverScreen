using System;

namespace SilverScreen.Domain.Cinema
{
	public class CinemaAdded : IDomainEvent
	{
		public Guid Id { get; private set; }

		public string Name { get; private set; }

		public CinemaAdded(Guid id, string name)
		{
			Id = id;
			Name = name;
		}
	}
}