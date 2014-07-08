namespace SilverScreen.Domain.Screens
{
	public sealed class ScreenId : AbstractIdentity<string>
	{
		public override string Id { get; protected set; }

		public ScreenId(string id)
		{
			Id = id;
		}
	}
}