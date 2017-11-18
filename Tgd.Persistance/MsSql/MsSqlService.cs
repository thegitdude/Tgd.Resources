using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;
using Tgd.Persistance.Model;

namespace Tgd.Persistance.MsSql
{
    public class MsSqlService : IMsSqlService
    {
        private readonly IDbConnectionFactory _dbConnection; 

        public MsSqlService(IDbConnectionFactory dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<int> ExecuteAsync<T>(SqlPersistanceTask<T> task)
        {
            using (var dbConnection = await _dbConnection.GetConnectionAsync())
            {
                return await dbConnection.ExecuteAsync(task.Sql, task.Payload).ConfigureAwait(false);
            }
        }

        public async Task<IEnumerable<Tout>> QueryAsync<Tin, Tout>(SqlPersistanceTask<Tin> task)
        {
            using (var dbConnection = await _dbConnection.GetConnectionAsync())
            {
                return await dbConnection.QueryAsync<Tout>(task.Sql, task.Payload).ConfigureAwait(false);
            }
        }

        public async Task<Tout> QuerySingleAsync<Tin, Tout>(SqlPersistanceTask<Tin> task)
        {
            using (var dbConnection = await _dbConnection.GetConnectionAsync())
            {
                return await dbConnection.QueryFirstOrDefaultAsync<Tout>(task.Sql, task.Payload).ConfigureAwait(false);
            }
        }
    }
}
