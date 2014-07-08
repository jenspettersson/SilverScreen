namespace SilverScreen.Domain.BookableShows
{
	public class SeatMadeAvailable : IDomainEvent
	{
		public BookableShowId BookableShowId { get; private set; }
		public BookableSeatId SeatId { get; private set; }

		public SeatMadeAvailable(BookableShowId bookableShowId, BookableSeatId seatId)
		{
			BookableShowId = bookableShowId;
			SeatId = seatId;
		}
	}
}