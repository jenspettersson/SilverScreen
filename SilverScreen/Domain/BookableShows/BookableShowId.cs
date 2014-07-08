namespace SilverScreen.Domain.BookableShows
{
	public sealed class BookableShowId : AbstractIdentity<string>
	{
		public override string Id { get; protected set; }

		public BookableShowId(string id)
		{
			Id = id;
		}
	}
}