using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToDB.Configuration;

namespace NewLibrary.Controllers
{
    public class ConnectionStringSettings : IConnectionStringSettings
    {
        public string ConnectionString { get; set; }
        public string Name { get; set; }
        public string ProviderName { get; set; }
        public bool IsGlobal => false;
    }

    public class MySettings : ILinqToDBSettings
    {
        public IEnumerable<IDataProviderSettings> DataProviders => Enumerable.Empty<IDataProviderSettings>();

        public string DefaultConfiguration => "System.Data.SqlClient";
        public string DefaultDataProvider => "System.Data.SqlClient";

        public IEnumerable<IConnectionStringSettings> ConnectionStrings
        {
            get
            {
                yield return
                    new ConnectionStringSettings
                    {
                        Name = "Library",
                        ProviderName = "System.Data.SqlClient",
                        ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Database=Library;Trusted_Connection=True;"
                    };
            }
        }
    }
}
