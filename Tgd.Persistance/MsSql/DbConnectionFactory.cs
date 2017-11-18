using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Tgd.Persistance.MsSql
{
    public class DbConnectionFactory : IDbConnectionFactory
    {
        private readonly string _connectionString;

        public DbConnectionFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<IDbConnection> GetConnectionAsync()
        {
            var dbConnection = new SqlConnection(_connectionString);
            await dbConnection.OpenAsync();

            return dbConnection;
        }
    }
}
