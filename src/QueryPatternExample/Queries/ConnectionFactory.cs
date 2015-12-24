using System.Data;
using System.Data.SqlClient;

namespace QueryPatternExample.Queries
{
    public class ConnectionFactory : IConnectionFactory
    {
        private readonly ISettings _settings;

        public ConnectionFactory(ISettings settings)
        {
            _settings = settings;
        }

        public IDbConnection GetConnection()
        {
            return new SqlConnection(_settings.ConnectionString);
        }
    }
}