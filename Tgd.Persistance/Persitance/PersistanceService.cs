using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Tgd.Persistance.Firebase;
using Tgd.Persistance.Model;

namespace Tgd.Persistance.Persitance
{
    public class PersistanceService : IPersistanceService
    {
        private readonly IMsSqlService _msSqlService;
        private readonly IFirebaseService _firebaseService;

        public PersistanceService(
            IMsSqlService msSqlService,
            IFirebaseService firebaseService)
        {
            _msSqlService = msSqlService;
            _firebaseService = firebaseService;
        }

        public async Task<int> ExecuteAsync<T>(IPersistanceTask<T> task)
        {
            switch (task.PersistanceType)
            {
                case PersistanceType.Sql:
                    var sqlTask = task as SqlPersistanceTask<T>;
                    return await _msSqlService.ExecuteAsync<T>(sqlTask).ConfigureAwait(false);
                case PersistanceType.Firebase:
                    var firebaseTask = task as FirebasePersistanceTask<T>;
                    return await _firebaseService.ExecuteAsync<T>(firebaseTask).ConfigureAwait(false);
                default:
                    throw new ArgumentOutOfRangeException("no handler for persistance type");
            }
        }

        public async Task<IEnumerable<Tout>> QueryAsync<Tin, Tout>(IPersistanceTask<Tin> task)
        {
            switch (task.PersistanceType)
            {
                case PersistanceType.Sql:
                    var sqlTask = task as SqlPersistanceTask<Tin>;
                    return await _msSqlService.QueryAsync<Tin, Tout>(sqlTask).ConfigureAwait(false);
                case PersistanceType.Firebase:
                    var firebaseTask = task as FirebasePersistanceTask<Tin>;
                    return await _firebaseService.QueryAsync<Tin, Tout>(firebaseTask).ConfigureAwait(false);
                default:
                    throw new ArgumentOutOfRangeException("no handler for persistance type");
            }
        }

        public async Task<Tout> QuerySingleAsync<Tin, Tout>(IPersistanceTask<Tin> task)
        {
            switch (task.PersistanceType)
            {
                case PersistanceType.Sql:
                    var sqlTask = task as SqlPersistanceTask<Tin>;
                    return await _msSqlService.QuerySingleAsync<Tin, Tout>(sqlTask).ConfigureAwait(false);
                case PersistanceType.Firebase:
                    var firebaseTask = task as FirebasePersistanceTask<Tin>;
                    return await _firebaseService.QuerySingleAsync<Tin, Tout>(firebaseTask).ConfigureAwait(false);
                default:
                    throw new ArgumentOutOfRangeException("no handler for persistance type");
            }
        }
    }
}
