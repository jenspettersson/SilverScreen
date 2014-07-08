namespace SilverScreen.Domain.BookableShows
{
	public class SeatReserved : IDomainEvent
	{
		public BookableShowId BookableShowId { get; private set; }
		public BookableSeatId SeatId { get; private set; }

		public SeatReserved(BookableShowId bookableShowId, BookableSeatId seatId)
		{
			BookableShowId = bookableShowId;
			SeatId = seatId;
		}
	}
}