using System;
using System.Configuration;
using Migrator.Framework;
using Migrator.Providers;

using NUnit.Framework;

namespace Migrator.Tests
{
	[TestFixture]
	public class ProviderFactoryTest
	{
		[Test]
		public void CanGetDialectsForProvider()
		{
			var providers = new[] {"SqlServer", "Mysql", "SQLite", "PostgreSQL", "SqlServer2005", "SqlServerCe", "Oracle"};
            foreach (ProviderTypes provider in Enum.GetValues(typeof(ProviderTypes)))
            {
                Assert.IsNotNull(ProviderFactory.DialectForProvider(provider));
            }
			Assert.IsNull(ProviderFactory.DialectForProvider(ProviderTypes.none));			
		}

		[Test]
		[Category("MySql")]
		public void CanLoad_MySqlProvider()
		{
            ITransformationProvider provider = ProviderFactory.Create(ProviderTypes.Mysql,
			                                                          ConfigurationManager.AppSettings[
			                                                          	"MySqlConnectionString"], null);
			Assert.IsNotNull(provider);
		}

		[Test]
		[Category("Oracle")]
		public void CanLoad_OracleProvider()
		{
            ITransformationProvider provider = ProviderFactory.Create(ProviderTypes.Oracle,
			                                                          ConfigurationManager.AppSettings[
																																	"OracleConnectionString"], null);
			Assert.IsNotNull(provider);
		}

		[Test]
		[Category("Postgre")]
		public void CanLoad_PostgreSQLProvider()
		{
            ITransformationProvider provider = ProviderFactory.Create(ProviderTypes.PostgreSQL,
			                                                          ConfigurationManager.AppSettings[
																																	"NpgsqlConnectionString"], null);
			Assert.IsNotNull(provider);
		}

		[Test]
		[Category("SQLite")]
		public void CanLoad_SQLiteProvider()
		{
            ITransformationProvider provider = ProviderFactory.Create(ProviderTypes.SQLite,
			                                                          ConfigurationManager.AppSettings[
																																	"SQLiteConnectionString"], null);
			Assert.IsNotNull(provider);
		}

		[Test]
		[Category("SqlServer2005")]
		public void CanLoad_SqlServer2005Provider()
		{
            ITransformationProvider provider = ProviderFactory.Create(ProviderTypes.SqlServer2005,
			                                                          ConfigurationManager.AppSettings[
																																	"SqlServer2005ConnectionString"], null);
			Assert.IsNotNull(provider);
		}

		[Test]
		[Category("SqlServerCe")]
		public void CanLoad_SqlServerCeProvider()
		{
            ITransformationProvider provider = ProviderFactory.Create(ProviderTypes.SqlServerCe,
			                                                          ConfigurationManager.AppSettings[
																																	"SqlServerCeConnectionString"], null);
			Assert.IsNotNull(provider);
		}

		[Test]
		[Category("SqlServer")]
		public void CanLoad_SqlServerProvider()
		{
            ITransformationProvider provider = ProviderFactory.Create(ProviderTypes.SqlServer,
			                                                          ConfigurationManager.AppSettings[
																																	"SqlServerConnectionString"], null);
			Assert.IsNotNull(provider);
		}
	}
}