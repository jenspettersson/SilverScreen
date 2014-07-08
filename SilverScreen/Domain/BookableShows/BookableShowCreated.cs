using System;
using System.Collections.Generic;

namespace SilverScreen.Domain.BookableShows
{
	public class BookableShowCreated : IDomainEvent
	{
		public Guid Id { get; private set; }
		public Guid ScreenId { get; private set; }
		public DateTime ShowTime { get; private set; }
		public List<BookableSeat> Seats{ get; private set; }

		public BookableShowCreated(Guid id, Guid screenId, DateTime showTime, List<BookableSeat> seats)
		{
			Id = id;
			ScreenId = screenId;
			ShowTime = showTime;
			Seats = seats;
		}
	}
}