﻿using Bosphorus.Dao.NHibernate.Session.Factory.Builder;
using FluentNHibernate.Cfg.Db;

namespace Bosphorus.Library.Logging.Facade.Demo
{
    public class PersistenceConfigurerProvider : IPersistenceConfigurerProvider
    {
        public IPersistenceConfigurer GetPersistenceProvider(string providerName)
        {
            return
                SQLiteConfiguration
                .Standard
                .ConnectionString(@"data source=.\Demo.db3")
                .ShowSql();
        }
    }
}