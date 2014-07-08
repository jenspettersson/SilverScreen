using System;

namespace SilverScreen.Domain.BookableShows
{
	public class SeatMadeAvailable : IDomainEvent
	{
		public Guid BookableShowId { get; private set; }
		public Guid SeatId { get; private set; }

		public SeatMadeAvailable(Guid bookableShowId, Guid seatId)
		{
			BookableShowId = bookableShowId;
			SeatId = seatId;
		}
	}
}