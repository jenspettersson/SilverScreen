namespace SilverScreen.Domain.Bookings
{
	public sealed class BookingId : AbstractIdentity<string>
	{
		public override string Id { get; protected set; }

		public BookingId(string id)
		{
			Id = id;
		}
	}
}