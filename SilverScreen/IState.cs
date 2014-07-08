using SilverScreen.Domain;

namespace SilverScreen
{
    public interface IState
    {
        IIdentity Id { get; set; }
        void Mutate(IDomainEvent evt);
    }
}