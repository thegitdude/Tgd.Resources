using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Tgd.Persistance.Model;

namespace Tgd.Persistance.Firebase
{
    public class FirebaseService : IFirebaseService
    {
        public Task<int> ExecuteAsync<T>(FirebasePersistanceTask<T> task)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Tout>> QueryAsync<Tin, Tout>(FirebasePersistanceTask<Tin> task)
        {
            throw new NotImplementedException();
        }

        public Task<Tout> QuerySingleAsync<Tin, Tout>(FirebasePersistanceTask<Tin> task)
        {
            throw new NotImplementedException();
        }
    }
}
