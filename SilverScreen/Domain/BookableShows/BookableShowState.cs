using System;
using System.Collections.Generic;
using System.Linq;
using SilverScreen.Domain.Screens;

namespace SilverScreen.Domain.BookableShows
{
	public class BookableShowState : State
	{
		public BookableShowId BookableShowId { get; set; }

		public ScreenId ScreenId { get; set; }

		public DateTime ShowTime { get; set; }

		public List<BookableSeat> Seats { get; set; }

		public void When(BookableShowCreated evt)
		{
			BookableShowId = evt.Id;
			ScreenId = evt.ScreenId;
			ShowTime = evt.ShowTime;
			Seats = evt.Seats;
		}

		public void When(SeatMadeAvailable evt)
		{
			var seat = Seats.FirstOrDefault(x => x.Id == evt.SeatId);

			if (seat == null)
				return;

			seat.Status = BookableSeatStatus.Available;
		}

		public void When(SeatReserved evt)
		{
			var seat = Seats.FirstOrDefault(x => x.Id == evt.SeatId);

			if (seat == null)
				return;

			seat.Status = BookableSeatStatus.Reserved;
		}

		public void When(SeatBooked evt)
		{
			var seat = Seats.FirstOrDefault(x => x.Id == evt.SeatId);

			if (seat == null)
				return;

			seat.Status = BookableSeatStatus.Booked;
		}
	}
}