using System.Collections.Generic;
using System.Threading.Tasks;
using Tgd.Persistance.Model;

namespace Tgd.Persistance.Persitance
{
    public interface IPersistanceService
    {
        Task<int> ExecuteAsync<T>(IPersistanceTask<T> task);

        Task<IEnumerable<Tout>> QueryAsync<Tin, Tout>(IPersistanceTask<Tin> task);

        Task<Tout> QuerySingleAsync<Tin, Tout>(IPersistanceTask<Tin> task);
    }
}
