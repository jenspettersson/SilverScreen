namespace SilverScreen.Domain.Cinemas
{
	public class CinemaAdded : IDomainEvent
	{
		public CinemaId Id { get; private set; }

		public string Name { get; private set; }

		public CinemaAdded(CinemaId id, string name)
		{
			Id = id;
			Name = name;
		}
	}
}