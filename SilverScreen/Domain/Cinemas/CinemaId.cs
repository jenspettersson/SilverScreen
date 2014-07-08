namespace SilverScreen.Domain.Cinemas
{
	public sealed class CinemaId : AbstractIdentity<string>
	{
		public override string Id { get; protected set; }

		public CinemaId(string id)
		{
			Id = id;
		}
	}
}