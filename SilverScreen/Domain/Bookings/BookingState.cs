using System;
using System.Collections.Generic;
using SilverScreen.Domain.BookableShows;

namespace SilverScreen.Domain.Bookings
{
	public class BookingState : State
	{
		public BookingId Id { get; set; }
		
		public BookableShowId BookableShowId { get; set; }

		public List<Seat> BookedSeats { get; set; }
		
		public DateTime Created { get; set; }

		public void When(BookingCreated evt)
		{
			Id = evt.Id;
			BookableShowId = evt.BookableShowId;
			BookedSeats = evt.BookedSeats;
			Created = evt.Created;
		}
	}
}