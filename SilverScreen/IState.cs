namespace SilverScreen
{
    public interface IState
    {
        void Mutate(IDomainEvent evt);
    }
}