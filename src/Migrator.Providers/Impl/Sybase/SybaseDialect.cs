using System.Data;
using Migrator.Framework;
using Migrator.Providers.Impl.DB2;
using Migrator.Providers.Impl.Ingres;

namespace Migrator.Providers.Impl.Sybase
{
    public class SybaseDialect : Dialect
	{
        public SybaseDialect()
        {
        }


        public override ITransformationProvider GetTransformationProvider(Dialect dialect, string connectionString, string defaultSchema, string scope, string providerName)
		{
            return new SybaseTransformationProvider(dialect, connectionString, scope, providerName);
		}		
	}
}