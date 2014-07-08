namespace SilverScreen.Domain.BookableShows
{
	public sealed class BookableSeatId : AbstractIdentity<string>
	{
		public override string Id { get; protected set; }

		public BookableSeatId(string id)
		{
			Id = id;
		}
	}
}