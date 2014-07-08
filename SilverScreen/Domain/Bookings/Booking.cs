using System;
using System.Collections.Generic;
using SilverScreen.Domain.BookableShows;

namespace SilverScreen.Domain.Bookings
{
	public class Booking : AggregateBase<BookingState>
	{
		public Booking(BookingState state) : base(state) { }

		private Booking(BookingId id, BookableShowId bookableShowId, List<Seat> bookedSeats, DateTime created)
		{
			Apply(new BookingCreated(id, bookableShowId, bookedSeats, created));
		}

		public static Booking Create(BookableShowId bookableShowId, List<Seat> bookedSeats)
		{
			return new Booking(new BookingId(Guid.NewGuid().ToString()), bookableShowId, bookedSeats, DateTime.UtcNow);
		}
	}
}