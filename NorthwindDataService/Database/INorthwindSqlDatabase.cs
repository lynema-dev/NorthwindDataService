using System.Data.SqlClient;

namespace NorthwindDataService
{
    public interface INorthwindSqlDatabase
    {
        SqlConnection CreateDatabaseConnection(string connectionstring);
        SqlDataReader CreateSqlDataReader(string procedureName, string parameterName, string parameterValue);

    }
}