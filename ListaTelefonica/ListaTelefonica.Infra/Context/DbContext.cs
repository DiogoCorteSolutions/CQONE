using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using ListaTelefonica.Infra.Models;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace ListaTelefonica.Infra.Context
{
    public class DbContext
    {

        public static ISession OpenSession()
        {
            ISessionFactory sessionFactory = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012
                 .ConnectionString(@"Data Source=sql5018.site4now.net;Initial Catalog=DB_A438DB_cortediogo;Persist Security Info=True;User ID=DB_A438DB_cortediogo_admin;Password=desenv10@")
                              .ShowSql()
                )
               .Mappings(m =>
                          m.FluentMappings
                              .AddFromAssemblyOf<Agenda>())
                .ExposeConfiguration(cfg => new SchemaExport(cfg)
                                                .Create(false, false))
                .BuildSessionFactory();
            return sessionFactory.OpenSession();
        }
    }
}
