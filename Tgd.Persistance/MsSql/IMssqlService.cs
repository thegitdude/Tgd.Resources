using System.Collections.Generic;
using System.Threading.Tasks;
using Tgd.Persistance.Model;

namespace Tgd.Persistance
{
    public interface IMsSqlService
    {
        Task<int> ExecuteAsync<T>(SqlPersistanceTask<T> task);

        Task<IEnumerable<Tout>> QueryAsync<Tin, Tout>(SqlPersistanceTask<Tin> task);

        Task<Tout> QuerySingleAsync<Tin, Tout>(SqlPersistanceTask<Tin> task);
    }
}
