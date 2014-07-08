namespace SilverScreen.Domain.BookableShows
{
	public class SeatBooked : IDomainEvent
	{
		public BookableShowId BookableShowId { get; private set; }

		public BookableSeatId SeatId { get; private set; }

		public SeatBooked(BookableShowId bookableShowId, BookableSeatId seatId)
		{
			BookableShowId = bookableShowId;
			SeatId = seatId;
		}
	}
}