using System;
using System.Data.SqlClient;

namespace Store.Core.Data.Connection
{
    public class DataModelService
    {
        private static string _connectionString = string.Empty;

        public static System.Data.IDbConnection CreateConnection()
        {
           
             _connectionString = Utils.ConfigReader.GetValue("dbConnectionString");

            return new SqlConnection(_connectionString);

        }
    }
}
