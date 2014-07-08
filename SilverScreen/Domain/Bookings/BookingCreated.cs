using System;
using System.Collections.Generic;
using SilverScreen.Domain.BookableShows;

namespace SilverScreen.Domain.Bookings
{
	public class BookingCreated : IDomainEvent
	{
		public BookingId Id { get; private set; }
		public BookableShowId BookableShowId { get; private set; }
		public List<Seat> BookedSeats { get; private set; }
		public DateTime Created { get; private set; }

		public BookingCreated(BookingId id, BookableShowId bookableShowId, List<Seat> bookedSeats, DateTime created)
		{
			Id = id;
			BookableShowId = bookableShowId;
			BookedSeats = bookedSeats;
			Created = created;
		}
	}
}