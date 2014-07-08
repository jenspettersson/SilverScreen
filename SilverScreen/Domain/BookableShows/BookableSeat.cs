using System;

namespace SilverScreen.Domain.BookableShows
{
	public class BookableSeat
	{
		public BookableSeatId Id { get; private set; }

		public int RowNumber { get; private set; }

		public int SeatNumber { get; private set; }

		public BookableSeatStatus Status { get; set; }

		public BookableSeat()
		{
			Id = new BookableSeatId(Guid.NewGuid().ToString());
		}
	}
}