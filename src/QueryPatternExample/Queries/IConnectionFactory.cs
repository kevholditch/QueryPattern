using System.Data;

namespace QueryPatternExample.Queries
{
    public interface IConnectionFactory
    {
        IDbConnection GetConnection();
    }
}