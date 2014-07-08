using System;

namespace SilverScreen.Domain.BookableShows
{
	public class SeatReserved : IDomainEvent
	{
		public Guid BookableShowId { get; private set; }
		public Guid SeatId { get; private set; }

		public SeatReserved(Guid bookableShowId, Guid seatId)
		{
			BookableShowId = bookableShowId;
			SeatId = seatId;
		}
	}
}