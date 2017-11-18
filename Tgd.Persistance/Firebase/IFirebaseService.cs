using System.Collections.Generic;
using System.Threading.Tasks;
using Tgd.Persistance.Model;

namespace Tgd.Persistance.Firebase
{
    public interface IFirebaseService
    {
        Task<int> ExecuteAsync<T>(FirebasePersistanceTask<T> task);

        Task<IEnumerable<Tout>> QueryAsync<Tin, Tout>(FirebasePersistanceTask<Tin> task);

        Task<Tout> QuerySingleAsync<Tin, Tout>(FirebasePersistanceTask<Tin> task);
    }
}
