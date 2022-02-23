using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2P
{
    class DbConnection
    {
        /// <summary>
        /// This variable is SqlConnection variable.
        /// </summary>
        private SqlConnection connection;
        /// <summary>
        /// This function which  is getter and setter for connect variable.
        /// </summary>
        public SqlConnection Connection { get => connection; set => connection = value; }
        /// <summary>
        ///  Function which provides to connect databse
        /// </summary>
        public void OnConnection()
        {
            connection = new SqlConnection(GetConnectionString());
        }
        /// <summary>
        ///  Function which provides to open connection for database from program.
        /// </summary>
        public void OpenConnection()
        {
            connection.Open();
            Console.WriteLine("State: {0}", connection.State);
            Console.WriteLine("ConnectionString: {0}",
                connection.ConnectionString);
        }
        /// <summary>
        ///   Function which provides to close connection for database from program.  
        /// </summary>
        public void CloseConnection()
        {
            connection.Close();
            Console.WriteLine("State: {0}", connection.State);
            Console.WriteLine("ConnectionString: {0}",
                connection.ConnectionString);
        }
        /// <summary>
        ///   Function which provides to avoid storing the connection string in our code.   
        /// </summary>
        /// <returns> connectionString </returns>
        static private string GetConnectionString()
        {
            //RETURNS connectionString to DataBase;
        }
    }
}
