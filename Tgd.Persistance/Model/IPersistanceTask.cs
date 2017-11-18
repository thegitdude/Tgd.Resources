namespace Tgd.Persistance.Model
{
    public interface IPersistanceTask<T>
    {
        T Payload { get; }

        PersistanceType PersistanceType { get; }
    }
}
