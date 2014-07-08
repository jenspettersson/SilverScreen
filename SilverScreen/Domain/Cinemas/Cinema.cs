using System;

namespace SilverScreen.Domain.Cinemas
{
	public class Cinema : AggregateBase<CinemaState>
	{
		public Cinema(CinemaState state) : base(state) { }

		private Cinema(CinemaId id, string name)
        {
            Apply(new CinemaAdded(id, name));
        }

		public static Cinema Add(string name)
        {
			return new Cinema(new CinemaId(Guid.NewGuid().ToString()), name);
        }
	}
}
