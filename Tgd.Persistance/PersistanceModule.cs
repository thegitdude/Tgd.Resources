using System;
using Autofac;
using Tgd.Persistance.MsSql;
using Tgd.Persistance.Firebase;
using Tgd.Persistance.Persitance;

namespace Tgd.Persistance
{
    public class PersistanceModule : Module
    {
        public string ConnectionString { get; set; }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MsSqlService>().As<IMsSqlService>();
            builder.RegisterType<FirebaseService>().As<IFirebaseService>();
            builder.RegisterType<PersistanceService>().As<IPersistanceService>();

            builder.Register(c => new DbConnectionFactory(ConnectionString))
                .As<IDbConnectionFactory>()
                .SingleInstance();
        }
    }
}
