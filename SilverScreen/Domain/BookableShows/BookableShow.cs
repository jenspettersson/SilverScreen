using System;
using System.Collections.Generic;
using SilverScreen.Domain.Screens;

namespace SilverScreen.Domain.BookableShows
{
	public class BookableShow : AggregateBase<BookableShowState>
	{
		public BookableShow(BookableShowState state) : base(state) { }

		private BookableShow(BookableShowId id, ScreenId screenId, DateTime showTime, List<BookableSeat> seats)
		{
			Apply(new BookableShowCreated(id, screenId, showTime, seats));
		}

		public static BookableShow Create(ScreenId screenId, DateTime showTime, List<BookableSeat> seats)
		{
			return new BookableShow(new BookableShowId(Guid.NewGuid().ToString()), screenId, showTime, seats);
		}

		public void MakeSeatAvailable(BookableSeatId seatId)
		{
			Apply(new SeatMadeAvailable(State.BookableShowId, seatId));
		}

		public void ReserveSeat(BookableSeatId seatId)
		{
			Apply(new SeatReserved(State.BookableShowId, seatId));
		}

		public void BookSeat(BookableSeatId seatId)
		{
			Apply(new SeatBooked(State.BookableShowId, seatId));
		}
	}
}