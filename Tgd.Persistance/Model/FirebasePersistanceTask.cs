namespace Tgd.Persistance.Model
{
    public class FirebasePersistanceTask<T> : IPersistanceTask<T>
    {
        public FirebasePersistanceTask(
            PersistanceType type, 
            T payload, 
            string sql)
        {
            PersistanceType = type;
            Payload = payload;
            Sql = sql;
        }

        public T Payload { get; set; }

        public string Sql { get; set; }

        public PersistanceType PersistanceType { get; }
    }
}
