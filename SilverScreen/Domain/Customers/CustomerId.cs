namespace SilverScreen.Domain.Customers
{
    public sealed class CustomerId : AbstractIdentity<string>
    {
        public override string Id { get; protected set; }

        public CustomerId(string id)
        {
            Id = id;
        }
    }
}