using System;
using System.Collections.Generic;
using SilverScreen.Domain.Screens;

namespace SilverScreen.Domain.BookableShows
{
	public class BookableShowCreated : IDomainEvent
	{
		public BookableShowId Id { get; private set; }
		public ScreenId ScreenId { get; private set; }
		public DateTime ShowTime { get; private set; }
		public List<BookableSeat> Seats{ get; private set; }

		public BookableShowCreated(BookableShowId id, ScreenId screenId, DateTime showTime, List<BookableSeat> seats)
		{
			Id = id;
			ScreenId = screenId;
			ShowTime = showTime;
			Seats = seats;
		}
	}
}