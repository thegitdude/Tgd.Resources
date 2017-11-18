namespace Tgd.Persistance.Model
{
    public class SqlPersistanceTask<T> : IPersistanceTask<T>
    {
        public SqlPersistanceTask(
            PersistanceType type,
            T payload, 
            string sql)
        {
            PersistanceType = type;
            Payload = payload;
            Sql = sql;
        }

        public T Payload { get; }

        public string Sql { get; }

        public PersistanceType PersistanceType { get; }
    }
}
