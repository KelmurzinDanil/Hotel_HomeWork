using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    internal class DB
    {
        SqlConnection connection = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB; Database=DBHotel; Trusted_Connection=True;"); 

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public SqlConnection GetConnection()
        {
            return connection;
        }
    }
}
