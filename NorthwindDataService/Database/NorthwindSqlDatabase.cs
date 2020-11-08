using System;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace NorthwindDataService
{
    public class NorthwindSqlDatabase : INorthwindSqlDatabase
    {
        public readonly string _connectionstring =
            @"Server=localhost\SQLEXPRESS;Database=master;Initial Catalog = Northwind;Trusted_Connection=True;";
        public SqlConnection nw;

        public NorthwindSqlDatabase()
        {
            nw = CreateDatabaseConnection(_connectionstring);
        }

        public SqlConnection CreateDatabaseConnection(string connectionstring)
        {
            SqlConnection cnn = new SqlConnection(connectionstring);
            cnn.Open();
            return cnn;
        }

        public SqlDataReader CreateSqlDataReader(string procedureName, string parameterName, string parameterValue)
        {
            SqlCommand cmd = new SqlCommand(procedureName, nw)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };
            cmd.Parameters.Add(new SqlParameter(parameterName, parameterValue));

            return cmd.ExecuteReader();
        }



    }
}
