using System;
using System.Collections.Generic;
using System.Data.Common;

namespace Migrator.Providers.Impl.DB2
{
    /// <summary>
    /// DB2 transformation provider
    /// </summary>
    public class DB2TransformationProvider : TransformationProvider
    {
        public DB2TransformationProvider(Dialect dialect, string connectionString, string scope, string providerName)
            : base(dialect, connectionString, null, scope)
        {
            if (string.IsNullOrEmpty(providerName)) providerName = "IBM.Data.DB2";
            var fac = DbProviderFactories.GetFactory(providerName);
            _connection = fac.CreateConnection();
            _connection.ConnectionString = _connectionString;
            this._connection.Open();
        }

        public override List<string> GetDatabases()
        {
            throw new NotImplementedException();
        }

        public override bool ConstraintExists(string table, string name)
        {
            throw new NotImplementedException();
        }

        public override bool IndexExists(string table, string name)
        {
            throw new NotImplementedException();
        }
    }
}